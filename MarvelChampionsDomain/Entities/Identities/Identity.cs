using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Identities;

public sealed class Identity : BaseEntity, IIdentity
{
    public EntityId CardSetId { get; }
    public string Title { get; }
    public int StartingLife { get; }
    public ICard? Card { get; private set; }
    public Identity(EntityId cardSetId, string title, int startingLife) : this(EntityId.Create(), cardSetId, title, startingLife) { }
    public Identity(EntityId id, EntityId cardSetId, string title, int startingLife) : base(id)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
        if (startingLife <= 0) throw new ArgumentOutOfRangeException(nameof(startingLife));
        CardSetId = cardSetId;
        Title = title;
        StartingLife = startingLife;
    }
    public void SetCard(ICard card) => Card = card;
    public override string ToString() => $"Identity[{Title}, {StartingLife}]";
}