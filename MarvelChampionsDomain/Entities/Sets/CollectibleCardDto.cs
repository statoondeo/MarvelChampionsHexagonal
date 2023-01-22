using System.Text.Json;

using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Sets;

[Serializable]
public sealed class CollectibleCardDto
{
	public EntityId? Id { get; set; }
	public EntityId? CardSet { get; set; }
	public string? Title { get; set; }
	public TypeEnum? Type { get; set; }
	public ClassificationEnum? Classification { get; set; }
	public ICommand? SetupCommand { get; set; }
}
public sealed class CollectibleCardBuilder
{
	public EntityId? Id { get; private set; }
	public string? Title { get; private set; }
	public EntityId? CardSet { get; private set; }
	public TypeEnum? Type { get; private set; }
	public ClassificationEnum? Classification { get; private set; }
	public CollectibleCardBuilder WithId(EntityId id)
	{
		ArgumentNullException.ThrowIfNull(id);
		Id = id;
		return this;
	}
	public CollectibleCardBuilder WithTitle(string title)
	{
		if (string.IsNullOrWhiteSpace(title))throw new ArgumentNullException(nameof(title));
		Title = title;
		return this;
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
	public CollectibleCardDto Build(bool serialize)
	{
		CollectibleCardDto dto = new()
		{
			Id = this.Id,
			Title = this.Title,
			CardSet = this.CardSet,
			Type = this.Type,
			Classification = this.Classification,
		};
		if (!serialize) return dto;
		File.WriteAllText(dto.Id!.ToString() + ".txt", JsonSerializer.Serialize(dto));
		return dto;
	}
	public CollectibleCardDto Build() => Build(false);
}