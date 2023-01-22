using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectVillainIdentityCommand : ICommand
{
	public void Execute()
	{
		// Constitution de la liste des villains pour sélection
		IVillainIdentityRepository villainIdentityRepository = ServiceLocator.Instance.Get<IVillainIdentityRepository>();
		List<CollectibleCardDto> identities = villainIdentityRepository
			.GetAll()
			.Select(identity => new CollectibleCardBuilder().WithId(identity.Id).WithTitle(identity.Title).Build())
			.ToList();

		// Sélection du villain
		EntityId selectedIdentityId = ServiceLocator.Instance.Get<IGameService>()
			.SelectOneAndOnlyOneCard
			.Select(identities).Id!;

		// Initialisation des données du villain sélectionné
		IVillainIdentity selectedIdentity = villainIdentityRepository.GetById(selectedIdentityId);
		IVillainPlayer villain = ServiceLocator.Instance.Get<IVillainService>().Villain!;
		villain.InitIdentity(selectedIdentityId);

		// Constitution du deck
		List<CollectibleCardDto> deck = new();

		// Ajout des cartes d'identité
		ICardSetRepository cardSetRepository = ServiceLocator.Instance.Get<ICardSetRepository>();
		deck.AddRange(cardSetRepository.GetById(selectedIdentity.IdentityCardSetId).Cards);
		deck.AddRange(cardSetRepository.GetById(selectedIdentity.StandardCardSetId).Cards);
		deck.AddRange(cardSetRepository.GetById(selectedIdentity.CardSetId).Cards);
		deck.AddRange(cardSetRepository.GetById(selectedIdentity.SchemeCardSetId).Cards);

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
			LocationEnum cardlocation = LocationEnum.Deck;
			if (TypeEnum.Villain.Equals(collectibleCard.Type))
			{
				cardlocation = LocationEnum.Battlefield;
			}
			else if (TypeEnum.MainSchemeA.Equals(collectibleCard.Type) || TypeEnum.MainSchemeB.Equals(collectibleCard.Type))
			{
				cardlocation = LocationEnum.MainScheme;
			}
			cardBuilder.WithLocation(cardlocation);
			cardBuilder.WithOwner(villain.Id);
			cards.Add(cardBuilder.Build());
		});

		// Alimention du service avec les cartes du villain
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
