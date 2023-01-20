using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Sets;
public sealed class CardSet : BaseEntity, ICardSet
{
	public bool Identity { get; }
	public bool Encounter { get; }
	public bool Standard { get; }
	public string Description { get; }
	public List<CollectibleCardDto> Cards { get; }
	public CardSet(EntityId id, bool identity, bool encounter, bool standard, string description) 
		: this(id, identity, encounter, standard, description, new List<CollectibleCardDto>()) { }
	public CardSet(EntityId id, bool identity, bool encounter, bool standard, string description, List<CollectibleCardDto> cards) 
		: base(id)
	{
		ArgumentNullException.ThrowIfNull(cards);
		Identity = identity;
		Encounter = encounter;
		Standard = standard;
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
