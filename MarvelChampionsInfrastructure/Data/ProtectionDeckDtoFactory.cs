using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class ProtectionDeckDtoFactory
{
	public static ICardSet Create() => new CardSet(false, "Protection from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Black Widow" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Luke Cage" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Counter Punch" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Counter Punch" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Get Behind Me" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Get Behind Me" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Protection" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Protection" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Justice" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Med Team" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Med Team" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Armored Vest" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Armored Vest" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Indomitable" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Indomitable" },
		});
}
