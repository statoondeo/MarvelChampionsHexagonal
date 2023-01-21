using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Sets;

public sealed class CollectibleCardDto
{
	public EntityId? Id { get; set; }
	public EntityId? CardSet { get; set; }
	public string? Title { get; set; }
	public TypeEnum? Type { get; set; }
}