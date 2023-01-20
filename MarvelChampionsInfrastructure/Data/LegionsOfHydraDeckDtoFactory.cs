using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class LegionsOfHydraDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create("8ed34e14-8926-409f-a131-e0b35acd2c18");
	public static ICardSet Create() => new CardSet(CardSetId, false, true, false, "Legions of Hydra", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("f714577a-11f4-4957-8d8a-fb3af76c235e"), CardSet = CardSetId, Title = "Legions of Hydra" },
			new CollectibleCardDto() { Id = EntityId.Create("0d8dce9e-573b-496c-a0aa-248c790b36dd"), CardSet = CardSetId, Title = "Legions of Hydra" },
			new CollectibleCardDto() { Id = EntityId.Create("b69d7a8e-a9b7-459c-9b98-32c0a04c8b27"), CardSet = CardSetId, Title = "Madame Hydra" },
			new CollectibleCardDto() { Id = EntityId.Create("120cf0c5-fb4e-43c3-a7ea-6b0e2d495c6f"), CardSet = CardSetId, Title = "Hydra Soldier" },
			new CollectibleCardDto() { Id = EntityId.Create("29415f57-81a1-49dc-a890-6274c2b7dfc8"), CardSet = CardSetId, Title = "Hydra Soldier" },
			new CollectibleCardDto() { Id = EntityId.Create("0c7ff983-75a9-43a7-9f9b-dadebc712bc5"), CardSet = CardSetId, Title = "Hydra Soldier" },
		});
}
