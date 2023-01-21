using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetVillainDeckCommand : ICommand
{	public void Execute()
	{
		ServiceLocator.Instance.Get<IGameService>()
		.SelectVillainDeckStrategy
		.SelectVillainDeck(
			ServiceLocator.Instance.Get<ICardSetRepository>()
				.GetAll()
				.Where(cardSet => !cardSet.Identity && cardSet.Encounter && !cardSet.Standard)
				.ToList());

		List<CollectibleCardDto> deck = new();
		IVillainPlayer villain = ServiceLocator.Instance.Get<IVillainService>().Villain!;
		IVillainIdentity villainIdentity = ServiceLocator.Instance.Get<IVillainIdentityRepository>().GetById(villain.Identity!);

		// Ajout des cartes d'identité
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villainIdentity.IdentityCardSetId).Cards);
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villainIdentity.StandardCardSetId).Cards);
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villainIdentity.CardSetId).Cards);
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villainIdentity.SchemeCardSetId).Cards);

		// Ajout des cartes du deck
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villain.ModularCardSetId!).Cards);

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
			card.SetOwner(villain.Id);
			cards.Add(card);
		});
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
