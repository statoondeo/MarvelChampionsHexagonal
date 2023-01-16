using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Sets;
public sealed class CardSet : BaseEntity, ICardSet
{
	public bool Identity { get; }
	public string Description { get; }
	public List<CollectibleCardDto> Cards { get; }
	public CardSet(bool identity, string description) : this(identity, description, new List<CollectibleCardDto>()) { }
	public CardSet(bool identity, string description, List<CollectibleCardDto> cards) : base(EntityId.Create())
	{
		ArgumentNullException.ThrowIfNull(cards);
		Identity = identity;
		Description = description;
		Cards = cards;
	}
	public void Append(CollectibleCardDto card)
	{
		ArgumentNullException.ThrowIfNull(card);
		Cards.Add(card);
	}
	public void Append(ICardSet cardSet)
	{
		ArgumentNullException.ThrowIfNull(cardSet);
		Cards.AddRange(cardSet.Cards);
	}
}
