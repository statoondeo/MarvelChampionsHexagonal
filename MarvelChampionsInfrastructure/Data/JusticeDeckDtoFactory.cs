using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class JusticeDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("8c52ff7f-9bdf-4a25-bad4-7685ff89b1cd"));
	public static ICardSet Create() => new CardSet(false, false, "Justice from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("e57971f5-766a-4d76-b126-5a61b5117146"), CardSet = CardSetId, Title = "Daredevil" },
			new CollectibleCardDto() { Id = EntityId.Create("93d18d5c-164a-47e2-ad7b-a8c83720c92b"), CardSet = CardSetId, Title = "Jessica Jones" },
			new CollectibleCardDto() { Id = EntityId.Create("5271e086-0113-4de4-9b81-c29b60441a9f"), CardSet = CardSetId, Title = "For Justice" },
			new CollectibleCardDto() { Id = EntityId.Create("87358dce-7d90-49f4-8915-eb3c8b4dd88c"), CardSet = CardSetId, Title = "For Justice" },
			new CollectibleCardDto() { Id = EntityId.Create("2212237c-d5f5-4955-8279-f9ee26e95d0f"), CardSet = CardSetId, Title = "Great Responsability" },
			new CollectibleCardDto() { Id = EntityId.Create("6e799274-fb08-456f-a355-c33108952de3"), CardSet = CardSetId, Title = "Great Responsability" },
			new CollectibleCardDto() { Id = EntityId.Create("85dfdfe3-d64d-4b9c-b71e-616e331d6766"), CardSet = CardSetId, Title = "The Power Of Justice" },
			new CollectibleCardDto() { Id = EntityId.Create("bfbd863c-fb20-4ea9-b840-f28808e208ab"), CardSet = CardSetId, Title = "The Power Of Justice" },
			new CollectibleCardDto() { Id = EntityId.Create("17ac9e45-0572-42dc-bcd9-efc5c9663dce"), CardSet = CardSetId, Title = "Interrogation Room" },
			new CollectibleCardDto() { Id = EntityId.Create("eab49ffa-5cfb-481d-9ea8-524223d25b55"), CardSet = CardSetId, Title = "Interrogation Room" },
			new CollectibleCardDto() { Id = EntityId.Create("9394614e-aed4-4bf3-9ce9-d503a5a12ca8"), CardSet = CardSetId, Title = "Surveillance Team" },
			new CollectibleCardDto() { Id = EntityId.Create("3a210238-87d4-4111-9e3e-ae64cdc0543a"), CardSet = CardSetId, Title = "Surveillance Team" },
			new CollectibleCardDto() { Id = EntityId.Create("0f241573-0846-40a6-815b-c0907c6f2811"), CardSet = CardSetId, Title = "Heroic Intuition" },
			new CollectibleCardDto() { Id = EntityId.Create("011afd5e-fe14-4218-8708-5ffae3f9844b"), CardSet = CardSetId, Title = "Heroic Intuition" }
		});
}
