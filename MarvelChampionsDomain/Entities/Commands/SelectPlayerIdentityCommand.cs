using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectPlayerIdentityCommand : ICommand
{
	private readonly IHeroPlayer Player;
	public SelectPlayerIdentityCommand(IHeroPlayer player) => Player = player;
	public void Execute()
	{
		ISet<EntityId> usedHeroes = ServiceLocator.Instance.Get<IPlayerService>()
			.Players
			.Where(player => player.Identity is not null)
			.Select(player => player.Identity!)
			.ToHashSet();
		ServiceLocator.Instance.Get<IGameService>()
			.SelectPlayerIdentityStrategy
			.SelectIdentityForPlayer(
				Player,
				ServiceLocator.Instance.Get<IHeroIdentityRepository>()
					.GetAll()
					.Where(hero => !usedHeroes.Contains(hero.Id))
					.Select(hero => hero)
					.ToList());

		IHeroIdentity identity = ServiceLocator.Instance.Get<IHeroIdentityRepository>().GetById(Player.Identity!);
		List<CollectibleCardDto> deck = new();
		
		// Ajout des cartes de l'identité
		deck.AddRange(
			ServiceLocator.Instance.Get<ICardSetRepository>()
			.GetById(identity.CardSetId).Cards);

		// Ajout des cartes de némésis
		deck.AddRange(
			ServiceLocator.Instance.Get<ICardSetRepository>()
			.GetById(identity.NemesisCardSetId).Cards);

		// Conversion en cartes jouables
		List<ICard> cards = new();
		deck.ForEach(collectibleCard =>
		{
			CardBuilder cardBuilder = new CardBuilder(
				collectibleCard.Id!,
				collectibleCard.CardSet!,
				collectibleCard.Title!,
				collectibleCard.Type!,
				ClassificationEnum.None);
			ICard card = cardBuilder.Build();
			card.SetOwner(Player.Id);
			cards.Add(card);
		});

		// Ajout des cartes au service
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
