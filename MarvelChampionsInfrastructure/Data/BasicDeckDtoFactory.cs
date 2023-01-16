using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class BasicDeckDtoFactory
{
	public static ICardSet Create() => new CardSet(false, "Basic from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Mockingbird" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Nick Fury" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Emergency" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "First Aid" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Haymaker" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Energy" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Genius" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Strength" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Avengers Mansion" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Helicarrier" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Tenacity" },
		});
}
