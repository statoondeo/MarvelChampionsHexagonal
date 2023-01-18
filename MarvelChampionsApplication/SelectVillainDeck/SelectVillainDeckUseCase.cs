using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsApplication.SelectVillainDeck;

public sealed class SelectVillainDeckUseCase : IUseCase
{
    private readonly SelectVillainDeckUseCaseInput Input;
    public SelectVillainDeckUseCase(SelectVillainDeckUseCaseInput input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Input = input;
    }
    public void Execute()
    {
        List<CollectibleCardDto> deck = new();
        EntityId villainId = ServiceLocator.Instance.Get<IVillainService>().Villain!.Id;
		IVillainIdentity villainIdentity = ServiceLocator.Instance.Get<IVillainIdentityRepository>().GetById(villainId);

        // Ajout des cartes d'identité
        deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villainIdentity.IdentityCardSetId).Cards);
        deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villainIdentity.StandardCardSetId).Cards);
        deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villainIdentity.CardSetId).Cards);
        deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(villainIdentity.SchemeCardSetId).Cards);

        // Ajout des cartes du deck
        deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(Input.Deck!.Id).Cards);

        List<ICard> cards = new();
        deck.ForEach(collectibleCard =>
        {
            ICard card = new Card(
                collectibleCard.Id!,
                collectibleCard.CardSet!,
                collectibleCard.Title!,
                string.Empty,
                TypeEnum.None,
                LocationEnum.None,
                ClassificationEnum.None,
                new NullCommand(),
                new NullCommand());
            card.SetOwner(villainId);
            cards.Add(card);
        });
        ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
    }
}
