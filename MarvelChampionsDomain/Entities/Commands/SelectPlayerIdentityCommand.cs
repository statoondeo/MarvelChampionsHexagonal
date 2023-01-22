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
		// Constitution de la liste des identités pour sélection
		List<EntityId> usedIdentities = ServiceLocator.Instance.Get<IPlayerService>()
			.Players
			.Where(player => player.Identity is not null)
			.Select(player => player.Identity!)
			.ToList(); 
		IHeroIdentityRepository identitiesRepository = ServiceLocator.Instance.Get<IHeroIdentityRepository>();
		List<CollectibleCardDto> identities = identitiesRepository
			.GetAll()
			.Where(identity => !usedIdentities.Contains(identity.Id))
			.Select(identity => new CollectibleCardBuilder().WithId(identity.Id).WithTitle(identity.Title).Build())
			.ToList();

		// Sélection de l'identité
		EntityId selectedIdentityId = ServiceLocator.Instance.Get<IGameService>()
			.SelectOneAndOnlyOneCard
			.Select(identities).Id!;

		// Initialisation des données du héros sélectionné
		IHeroIdentity selectedIdentity = identitiesRepository.GetById(selectedIdentityId);
		Player.InitIdentity(selectedIdentity.Id);

		// Constitution du deck
		List<CollectibleCardDto> deck = new();

		// Ajout des cartes de l'identité
		deck.AddRange(
			ServiceLocator.Instance.Get<ICardSetRepository>()
			.GetById(selectedIdentity.CardSetId).Cards);

		// Ajout des cartes de némésis
		deck.AddRange(
			ServiceLocator.Instance.Get<ICardSetRepository>()
			.GetById(selectedIdentity.NemesisCardSetId).Cards);

		// Conversion en cartes jouables
		List<ICard> cards = new();
		deck.ForEach(collectibleCard =>
		{
			CardBuilder cardBuilder = new(
				collectibleCard.Id!,
				collectibleCard.CardSet!,
				collectibleCard.Title!,
				collectibleCard.Type!,
				collectibleCard.Classification!);
			if (collectibleCard.SetupCommand is not null) cardBuilder.WithSetupCommand(collectibleCard.SetupCommand);
			cardBuilder.WithLocation(TypeEnum.Hero.Equals(collectibleCard.Type) ? LocationEnum.Battlefield : LocationEnum.Deck);
			cardBuilder.WithOwner(Player.Id);
			cards.Add(cardBuilder.Build());
		});

		// Ajout des cartes au service
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
