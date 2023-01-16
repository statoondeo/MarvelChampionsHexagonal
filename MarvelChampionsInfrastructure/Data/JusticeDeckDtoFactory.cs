using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class JusticeDeckDtoFactory
{
	public static ICardSet Create() => new CardSet(false, "Justice from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Daredevil" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Jessica Jones" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "For Justice" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "For Justice" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Great Responsability" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Great Responsability" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Justice" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Justice" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Interrogation Room" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Interrogation Room" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Surveillance Team" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Surveillance Team" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Heroic Intuition" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Heroic Intuition" }
		});
}
