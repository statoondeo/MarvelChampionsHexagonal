using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class AggressionDeckDtoFactory
{
	public static ICardSet Create() => new CardSet(false, "Aggression from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Hulk" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Tigra" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Chase Them Down" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Chase Them Down" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Relentless Assault" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Relentless Assault" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Uppercut" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Uppercut" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Aggression" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "The Power Of Aggression" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Tac Team" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Tac Team" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Combat Training" },
			new CollectibleCardDto() { Id = EntityId.Create(), Title = "Combat Training" }
		});
}
