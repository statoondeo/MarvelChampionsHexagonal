using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class BlackPantherDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("eb2cbcaa-505e-4ced-937b-0485e6ade130"));
	public static readonly EntityId CardId = EntityId.Create(new Guid("38c90b39-4784-48e2-ac88-e96d9e96b115"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("630b1ad8-92e6-47fe-a968-ce28c649f3e0"));
	public static readonly EntityId NemesisCardSetId = EntityId.Create(new Guid("f97cf80f-5625-4410-b645-be4f203e2e99"));
	public static ICardSet Create() => new CardSet(true, false, "Black Panther", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = CardId, CardSet = CardSetId, Title = "Black Panther" },
			new CollectibleCardDto() { Id = EntityId.Create("be305cc3-0ce0-4c92-bb25-eb41892ee43a"), CardSet = CardSetId, Title = "Shuri" },
			new CollectibleCardDto() { Id = EntityId.Create("b52fd4e3-ab07-4f01-8175-6f9a15938c84"), CardSet = CardSetId, Title = "Ancestral Knowledge" },
			new CollectibleCardDto() { Id = EntityId.Create("863159bd-281c-480e-a0da-2851daaac457"), CardSet = CardSetId, Title = "Wakanda Forever!" },
			new CollectibleCardDto() { Id = EntityId.Create("24beed4c-63e7-4e5d-b158-5896e86bb18f"), CardSet = CardSetId, Title = "Wakanda Forever!" },
			new CollectibleCardDto() { Id = EntityId.Create("0e195aae-983a-4c19-8bb1-18ac29c62541"), CardSet = CardSetId, Title = "Wakanda Forever!" },
			new CollectibleCardDto() { Id = EntityId.Create("fac4d2a4-0f7a-4466-8786-fe9aedd5bbe1"), CardSet = CardSetId, Title = "Wakanda Forever!" },
			new CollectibleCardDto() { Id = EntityId.Create("456dd610-b202-48f4-8ad3-77b153e86329"), CardSet = CardSetId, Title = "Vibranium" },
			new CollectibleCardDto() { Id = EntityId.Create("729784bf-1f2f-4e6f-9868-a993019f1411"), CardSet = CardSetId, Title = "Vibranium" },
			new CollectibleCardDto() { Id = EntityId.Create("12339111-ab51-4398-a662-d2a4ab5b61d4"), CardSet = CardSetId, Title = "Vibranium" },
			new CollectibleCardDto() { Id = EntityId.Create("eca2825e-9c78-4944-bbf4-7c7aac2b2c2d"), CardSet = CardSetId, Title = "The Golden City" },
			new CollectibleCardDto() { Id = EntityId.Create("a2ce3f36-9890-4381-b1e6-0416d21e4f32"), CardSet = CardSetId, Title = "Energy Daggers" },
			new CollectibleCardDto() { Id = EntityId.Create("06a2667a-7f60-4133-9b72-0687b0667871"), CardSet = CardSetId, Title = "Panther Claws" },
			new CollectibleCardDto() { Id = EntityId.Create("d9f6dac5-8c35-4848-99c3-6acd7a0ce076"), CardSet = CardSetId, Title = "Tactical Genius" },
			new CollectibleCardDto() { Id = EntityId.Create("dfc3873c-9e5c-48b9-b5b8-05d63599e58e"), CardSet = CardSetId, Title = "Vibranium Suit" },
			new CollectibleCardDto() { Id = EntityId.Create("6623452d-e89c-4537-aafe-41f4aba61c93"), CardSet = CardSetId, Title = "Affairs of State" },

			new CollectibleCardDto() { Id = EntityId.Create("0f21627e-c601-4128-b01b-52a13583adde"), CardSet = NemesisCardSetId, Title = "Usurp The Throne" },
			new CollectibleCardDto() { Id = EntityId.Create("ca3d608e-36c9-46a1-99fe-ceb83ca49b45"), CardSet = NemesisCardSetId, Title = "Killmonger" },
			new CollectibleCardDto() { Id = EntityId.Create("7ea431d0-0afd-4ded-aea1-26e37fa055c0"), CardSet = NemesisCardSetId, Title = "Heart-Shaped Herb" },
			new CollectibleCardDto() { Id = EntityId.Create("94b97912-8983-40a4-ae49-821010dfb00f"), CardSet = NemesisCardSetId, Title = "Ritual Combat" },
			new CollectibleCardDto() { Id = EntityId.Create("2df16495-5ba0-4053-ae25-e066c443540b"), CardSet = NemesisCardSetId, Title = "Ritual Combat" },
	});
}
