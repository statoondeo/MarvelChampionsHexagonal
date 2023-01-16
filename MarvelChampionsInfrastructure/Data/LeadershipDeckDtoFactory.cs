using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class LeadershipDeckDtoFactory
{
	public static ICardSet Create() => new CardSet(false, "Leadership from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Hawkeye" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Maria Hill" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Vision" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Get Ready" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Get Ready" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Get Ready" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Lead From The Front" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Lead From The Front" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Justice" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Make The call" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Leadership" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Leadership" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Triskelion" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Inspired" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Inspired" },
		});
}
