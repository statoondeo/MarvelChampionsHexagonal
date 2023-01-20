using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class LeadershipDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("bd1bf209-2165-423d-8856-33cbef50aab8"));
	public static ICardSet Create() => new CardSet(CardSetId, false, false, false, "Leadership from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("8e562392-be3e-41c3-8f6b-61e509d30b11"), CardSet = CardSetId, Title = "Hawkeye" },
			new CollectibleCardDto() { Id = EntityId.Create("eaf2d0f1-56a2-4aba-83aa-36ac6d2b7daa"), CardSet = CardSetId, Title = "Maria Hill" },
			new CollectibleCardDto() { Id = EntityId.Create("43851bdd-255c-44f0-a9cf-27b205175f8a"), CardSet = CardSetId, Title = "Vision" },
			new CollectibleCardDto() { Id = EntityId.Create("1f1bfb1a-13d7-4026-b359-526c144e7d6f"), CardSet = CardSetId, Title = "Get Ready" },
			new CollectibleCardDto() { Id = EntityId.Create("a1ca9dbe-fd7a-4020-ae10-9087babb357b"), CardSet = CardSetId, Title = "Get Ready" },
			new CollectibleCardDto() { Id = EntityId.Create("3d95e0e5-1034-446e-95fa-38ab674b2825"), CardSet = CardSetId, Title = "Get Ready" },
			new CollectibleCardDto() { Id = EntityId.Create("a8693d1a-1f4c-471e-8eee-7c1b46c1020f"), CardSet = CardSetId, Title = "Lead From The Front" },
			new CollectibleCardDto() { Id = EntityId.Create("a12a14ed-ee27-4fa1-9c1e-75825fc20ef4"), CardSet = CardSetId, Title = "Lead From The Front" },
			new CollectibleCardDto() { Id = EntityId.Create("247f02f2-41eb-44a6-8a3e-179b80c19d21"), CardSet = CardSetId, Title = "The Power Of Justice" },
			new CollectibleCardDto() { Id = EntityId.Create("ad2fd90b-173d-4feb-846a-af47dfd61a9b"), CardSet = CardSetId, Title = "Make The call" },
			new CollectibleCardDto() { Id = EntityId.Create("51b24467-9a4e-4175-bf65-812a01bc375b"), CardSet = CardSetId, Title = "The Power Of Leadership" },
			new CollectibleCardDto() { Id = EntityId.Create("2200b745-99e2-4e6c-babc-45cad72754fa"), CardSet = CardSetId, Title = "The Power Of Leadership" },
			new CollectibleCardDto() { Id = EntityId.Create("60d49ca1-0e0d-4d3b-8853-e9f151e5beaa"), CardSet = CardSetId, Title = "The Triskelion" },
			new CollectibleCardDto() { Id = EntityId.Create("e9e21e38-ce8e-420b-8c53-ab6962c56447"), CardSet = CardSetId, Title = "Inspired" },
			new CollectibleCardDto() { Id = EntityId.Create("0caae57c-d87a-45ab-9fb8-b5c78f0503c6"), CardSet = CardSetId, Title = "Inspired" },
		});
}
