using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Identities;

public sealed class HeroIdentity : BaseEntity, IHeroIdentity
{
	public EntityId CardSetId { get; }
	public EntityId NemesisCardSetId { get; }
	public string Title { get; }
	public int StartingLife { get; }
    public EntityId Card { get; set; }
    public HeroIdentity(EntityId id, EntityId cardSetId, EntityId nemesisCardSetId, EntityId card, string title, int startingLife) 
		: base(id)
    {
		ArgumentNullException.ThrowIfNull(cardSetId);
		ArgumentNullException.ThrowIfNull(nemesisCardSetId);
		ArgumentNullException.ThrowIfNull(card);

		if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
        if (startingLife <= 0) throw new ArgumentOutOfRangeException(nameof(startingLife));
        CardSetId = cardSetId;
		NemesisCardSetId = nemesisCardSetId;
		Card = card;
		Title = title;
        StartingLife = startingLife;
    }
    public override string ToString() => $"Hero[{Title}, {StartingLife}]";
}
