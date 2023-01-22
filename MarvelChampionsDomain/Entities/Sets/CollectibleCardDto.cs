using System.Runtime.CompilerServices;

using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Sets;

public sealed class CollectibleCardDto
{
	public CollectibleCardDto() { }
	public EntityId? Id { get; set; }
	public EntityId? CardSet { get; set; }
	public string? Title { get; set; }
	public TypeEnum? Type { get; set; }
	public ClassificationEnum? Classification { get; set; }
}
public sealed class CollectibleCardBuilder
{
	public EntityId Id { get; private set; }
	public string Title { get; private set; }
	public EntityId? CardSet { get; private set; }
	public TypeEnum? Type { get; private set; }
	public ClassificationEnum? Classification { get; private set; }

	public CollectibleCardBuilder(EntityId id, string title)
	{
		ArgumentNullException.ThrowIfNull(id);
		if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
		Id = id;
		Title = title;
	}
	public CollectibleCardBuilder WithCardSet(EntityId cardSet)
	{
		ArgumentNullException.ThrowIfNull(cardSet);
		CardSet = cardSet;
		return this;
	}
	public CollectibleCardBuilder WithType(TypeEnum type)
	{
		ArgumentNullException.ThrowIfNull(type);
		Type = type;
		return this;
	}
	public CollectibleCardBuilder WithClassification(ClassificationEnum classification)
	{
		ArgumentNullException.ThrowIfNull(classification);
		Classification = classification;
		return this;
	}
	public CollectibleCardDto Build() => new CollectibleCardDto()
		{
			Id = this.Id,
			Title = this.Title,
			CardSet = this.CardSet,
			Type = this.Type,
			Classification = this.Classification,
		};
}