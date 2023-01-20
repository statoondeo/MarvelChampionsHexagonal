using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class KlawDeckDtoFactory
{
	public static readonly EntityId StandardId = EntityId.Create("e9675ce1-0b5f-472c-9db0-a5778d490c95");
	public static readonly EntityId ExpertId = EntityId.Create("04613764-2ca7-4587-a25a-9bb45e4764d0");

	public static readonly EntityId IdentityId1 = EntityId.Create("329ff88e-4332-455b-ba2b-6795c12cbc89");
	public static readonly EntityId IdentityId2 = EntityId.Create("dc8df94c-6713-4171-a216-b12f60569e9a");
	public static readonly EntityId IdentityId3 = EntityId.Create("837ab1ca-b367-4f66-8c28-4ee77b55a273");

	public static readonly EntityId StandardIdentitySet = EntityId.Create("33c0e676-2d66-445c-9954-41188e224bb5");
	public static readonly EntityId ExpertIdentitySet = EntityId.Create("06b18842-c068-4465-bbee-8235b3d741e9");
	public static readonly EntityId CardSetId = EntityId.Create("d685ea33-807a-46e2-8a7a-9d633c4b11cf");
	public static readonly EntityId SchemeCardSetId = EntityId.Create("6c2cfe9f-1adb-4645-b9a7-e8862c6ab6c8");
	public static ICardSet CreateStandard() => new CardSet(StandardIdentitySet, true, true, false, "Klaw Standard", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId1, CardSet = StandardIdentitySet, Title = "Klaw 1" },
			new CollectibleCardDto() { Id = IdentityId2, CardSet = StandardIdentitySet, Title = "Klaw 2" },
		});
	public static ICardSet CreateExpert() => new CardSet(ExpertIdentitySet, true, true, false, "Klaw Expert", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId2, CardSet = ExpertIdentitySet, Title = "Klaw 2" },
			new CollectibleCardDto() { Id = IdentityId3, CardSet = ExpertIdentitySet, Title = "Klaw 3" },
	});
	public static ICardSet CreateDeck() => new CardSet(CardSetId, true, true, false, "Klaw Deck", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("965c9202-635e-4f7d-b5b1-f362669a1857"), CardSet = CardSetId, Title = "Sonic Converter" },
			new CollectibleCardDto() { Id = EntityId.Create("600a4cdd-04b1-49b9-b6a9-ffcd69958e95"), CardSet = CardSetId, Title = "Solid-Sound Body" },
			new CollectibleCardDto() { Id = EntityId.Create("31df9f51-38b8-4b05-842e-a5ab8cd9b40a"), CardSet = CardSetId, Title = "Armored Guard" },
			new CollectibleCardDto() { Id = EntityId.Create("4818f4f7-19b4-4ff2-a066-43ba6a887349"), CardSet = CardSetId, Title = "Armored Guard" },
			new CollectibleCardDto() { Id = EntityId.Create("18402598-8660-4764-8e06-75168f34b91a"), CardSet = CardSetId, Title = "Armored Guard" },
			new CollectibleCardDto() { Id = EntityId.Create("a51f62fd-429d-4066-ae76-33aa8075d280"), CardSet = CardSetId, Title = "Weapons Runner" },
			new CollectibleCardDto() { Id = EntityId.Create("eeab07f2-138b-4db2-a40d-1776add49dc7"), CardSet = CardSetId, Title = "Weapons Runner" },
			new CollectibleCardDto() { Id = EntityId.Create("c8c6699b-88f2-497b-b066-ff931f549e96"), CardSet = CardSetId, Title = "Klaw's Vengeance" },
			new CollectibleCardDto() { Id = EntityId.Create("8f518faf-0289-4e81-8f28-7375c52a0311"), CardSet = CardSetId, Title = "Klaw's Vengeance" },
			new CollectibleCardDto() { Id = EntityId.Create("2d3e42fe-5864-46e6-b602-3cb9f1a6dcf5"), CardSet = CardSetId, Title = "Sonic Boom" },
			new CollectibleCardDto() { Id = EntityId.Create("279f59c1-30ce-4796-8464-bb1fb172b3a3"), CardSet = CardSetId, Title = "Sonic Boom" },
			new CollectibleCardDto() { Id = EntityId.Create("67cf78c0-f91c-4c0c-9e2a-a257fc23c47d"), CardSet = CardSetId, Title = "Sound Manipulation" },
			new CollectibleCardDto() { Id = EntityId.Create("1c825f82-dae7-4d78-a710-621d67893c5c"), CardSet = CardSetId, Title = "Sound Manipulation" },
			new CollectibleCardDto() { Id = EntityId.Create("30e6bf80-1c99-406f-96c2-096184c5fea5"), CardSet = CardSetId, Title = "Defense Network" },
			new CollectibleCardDto() { Id = EntityId.Create("ec9e0bb2-43eb-46fe-9e38-30eb59341d0a"), CardSet = CardSetId, Title = "Illegal Arms Factory" },
			new CollectibleCardDto() { Id = EntityId.Create("c0848f93-ec00-4b77-9a2c-a9c45a3d3b01"), CardSet = CardSetId, Title = "The \"Immortal\" Klaw" },
		});
	public static ICardSet CreateScheme() => new CardSet(SchemeCardSetId, true, true, false, "Klaw Scheme", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("77c2d2ce-1d28-49f1-a7ed-769fbdf5f273"), CardSet = SchemeCardSetId, Title = "Underground Distribution - 1A" },
			new CollectibleCardDto() { Id = EntityId.Create("5a7ef5a8-655a-4d89-bae3-9cb0e87680e5"), CardSet = SchemeCardSetId, Title = "Underground Distribution - 1B" },
			new CollectibleCardDto() { Id = EntityId.Create("3ea1cf22-4840-4f0f-830d-4fe825f7f88a"), CardSet = SchemeCardSetId, Title = "Secret Rendezvous - 2A" },
			new CollectibleCardDto() { Id = EntityId.Create("accfd01b-63fd-48fa-888b-bcf477852359"), CardSet = SchemeCardSetId, Title = "Secret Rendezvous - 2B" },
		});
}
