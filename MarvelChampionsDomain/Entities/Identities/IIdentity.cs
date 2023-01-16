using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Identities;

public interface IIdentity : IEntity
{
    EntityId CardSetId { get; }
    string Title { get; }
    int StartingLife { get; }
    ICard? Card { get; }
    void SetCard(ICard card);
}
