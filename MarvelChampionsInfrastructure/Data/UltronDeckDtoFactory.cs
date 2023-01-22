using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class UltronDeckDtoFactory
{
	public static readonly EntityId StandardId = EntityId.Create("42543222-4295-49ae-a85e-3b4a363257fc");
	public static readonly EntityId ExpertId = EntityId.Create("aad9a555-da60-4153-8ae5-2e40a30d2149");

	public static readonly EntityId IdentityId1 = EntityId.Create("0533b9fd-fa57-454d-8a49-91c571c3c1f4");
	public static readonly EntityId IdentityId2 = EntityId.Create("51f07ae9-1b52-4a68-98c7-c0693c9cfc09");
	public static readonly EntityId IdentityId3 = EntityId.Create("2a45d8a5-df0b-42af-a306-f63954ee98a1");

	public static readonly EntityId StandardIdentitySet = EntityId.Create("39043f88-e37f-45f9-8ad3-74ec1455e8c3");
	public static readonly EntityId ExpertIdentitySet = EntityId.Create("cc7c0f06-cdde-4eac-aec2-edd776bedd10");
	public static readonly EntityId CardSetId = EntityId.Create("40ce5abc-6e2e-4e23-8734-04acbd46f16b");
	public static readonly EntityId SchemeCardSetId = EntityId.Create("d72e2882-3561-4904-81f6-92b3ae33ed6e");

	public static readonly string StandardTitle = "Ultron Standard";
	public static readonly int StandardStartingLife = 17;
	public static readonly string ExpertTitle = "Ultron Expert";
	public static readonly int ExpertStartingLife = 22;

	public static ICardSet CreateStandard() => new CardSet(StandardIdentitySet, true, true, false, StandardTitle, new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId1, Classification = ClassificationEnum.Identity, Type = TypeEnum.Villain, CardSet = CardSetId, Title = "Ultron 1" },
			new CollectibleCardDto() { Id = IdentityId2, Classification = ClassificationEnum.Identity, Type = TypeEnum.Villain, CardSet = CardSetId, Title = "Ultron 2" },
		});
	public static ICardSet CreateExpert() => new CardSet(ExpertIdentitySet, true, true, false, ExpertTitle, new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId2, Classification = ClassificationEnum.Identity, Type = TypeEnum.Villain, CardSet = CardSetId, Title = "Ultron 2" },
			new CollectibleCardDto() { Id = IdentityId3, Classification = ClassificationEnum.Identity, Type = TypeEnum.Villain, CardSet = CardSetId, Title = "Ultron 3" },
	});
	public static ICardSet CreateDeck() => new CardSet(CardSetId,true, true, false, "Ultron Deck", new List<CollectibleCardDto>()
		{           
			new CollectibleCardDto() { Id = EntityId.Create("e1570fdb-7b23-4b29-86a3-4357f9a3b953"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Environment, CardSet = CardSetId, Title = "Ultron Drones" },
			new CollectibleCardDto() { Id = EntityId.Create("739616e9-548d-45ff-870d-a853b90feea7"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Attachment, CardSet = CardSetId, Title = "Program Transmitter" },
			new CollectibleCardDto() { Id = EntityId.Create("737dd4e4-5083-4401-a533-cbeb0af08d5d"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Attachment, CardSet = CardSetId, Title = "Upgraded Drones" },
			new CollectibleCardDto() { Id = EntityId.Create("56539db6-923f-4327-b489-f11325def009"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Attachment, CardSet = CardSetId, Title = "Upgraded Drones" },
			new CollectibleCardDto() { Id = EntityId.Create("7ee7c9cb-fc59-4960-bdd2-b664f238671a"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Advanced Ultron Drone" },
			new CollectibleCardDto() { Id = EntityId.Create("914b6dad-3fbe-4a5d-8358-8f1e0814e0a3"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Advanced Ultron Drone" },
			new CollectibleCardDto() { Id = EntityId.Create("6f2507eb-d1ff-42c1-ad4d-e04b8c3bcacb"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Advanced Ultron Drone" },
			new CollectibleCardDto() { Id = EntityId.Create("c7fd6a98-369c-4afd-b432-1ec6f2d0c0d1"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Android Efficiency" },
			new CollectibleCardDto() { Id = EntityId.Create("987c9fbd-e27e-40b2-b185-28d308bf0462"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Android Efficiency" },
			new CollectibleCardDto() { Id = EntityId.Create("c4c5d47f-3f19-4529-9292-0443ea6e19d2"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Android Efficiency" },
			new CollectibleCardDto() { Id = EntityId.Create("5035d4fc-ac6c-4044-8b09-4b198f55430a"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Rage of Ultron" },
			new CollectibleCardDto() { Id = EntityId.Create("117fcd47-731c-4cdb-b60c-c1888abaa19e"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Rage of Ultron" },
			new CollectibleCardDto() { Id = EntityId.Create("28470dc0-e681-4683-8577-3cb5d2b21a1a"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Repair Sequence" },
			new CollectibleCardDto() { Id = EntityId.Create("155add67-13dc-439c-b224-22dd64f0e830"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Repair Sequence" },
			new CollectibleCardDto() { Id = EntityId.Create("fcdb8004-332d-44f4-94af-7324fa40eadc"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Swarm Attack" },
			new CollectibleCardDto() { Id = EntityId.Create("6dd347de-4e4d-499c-8ddc-2eca6d6c9893"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Swarm Attack" },
			new CollectibleCardDto() { Id = EntityId.Create("fdbb4f57-54a9-415c-a055-65aba09c37ae"), Classification = ClassificationEnum.Identity, Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "Drone Factory" },
			new CollectibleCardDto() { Id = EntityId.Create("8fa19386-45b8-46ec-b03f-151522874beb"), Classification = ClassificationEnum.Identity, Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "Invasive AI" },
			new CollectibleCardDto() { Id = EntityId.Create("033b3597-f2aa-4270-a5cd-3820272b990c"), Classification = ClassificationEnum.Identity, Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "Ultron's Imperative" },
		});
	public static ICardSet CreateScheme() => new CardSet(SchemeCardSetId, true, true, false, "Ultron Scheme", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("dd2b2678-0a4a-4aaf-9d6e-180a4a6b0c10"), Classification = ClassificationEnum.Identity, Type = TypeEnum.MainSchemeA, CardSet = SchemeCardSetId, Title = "The Crimson Cowl - 1A" },
			new CollectibleCardDto() { Id = EntityId.Create("ef31f50d-750d-499a-9241-995973195fd4"), Classification = ClassificationEnum.Identity, Type = TypeEnum.MainSchemeB, CardSet = SchemeCardSetId, Title = "The Crimson Cowl - 1B" },
			new CollectibleCardDto() { Id = EntityId.Create("0baa973f-6266-476c-920e-17f9efd7a3bd"), Classification = ClassificationEnum.Identity, Type = TypeEnum.MainSchemeA, CardSet = SchemeCardSetId, Title = "Assault on NORAD - 2A" },
			new CollectibleCardDto() { Id = EntityId.Create("2894f013-1350-49d0-ae77-d6251f6db6bd"), Classification = ClassificationEnum.Identity, Type = TypeEnum.MainSchemeB, CardSet = SchemeCardSetId, Title = "Assault on NORAD - 2B" },
			new CollectibleCardDto() { Id = EntityId.Create("03f9129a-2b8f-4672-a68d-2f54a55ac3eb"), Classification = ClassificationEnum.Identity, Type = TypeEnum.MainSchemeA, CardSet = SchemeCardSetId, Title = "Countdown to Oblivion - 3A" },
			new CollectibleCardDto() { Id = EntityId.Create("70805fd4-5aba-432b-9eab-88d38f05b1b6"), Classification = ClassificationEnum.Identity, Type = TypeEnum.MainSchemeB, CardSet = SchemeCardSetId, Title = "Countdown to Oblivion - 3B" },
		});
}
