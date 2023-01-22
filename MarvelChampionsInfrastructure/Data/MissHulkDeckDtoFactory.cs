using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class MissHulkDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("ee99fc6f-7983-48a3-8603-5e2d760d11a6"));
	public static readonly EntityId CardId = EntityId.Create(new Guid("5569c7f2-964d-4598-80eb-f4e098beac4d"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("085c8c14-fbfd-4661-b081-7689240c09b6"));
	public static readonly EntityId NemesisCardSetId = EntityId.Create(new Guid("8c8a7609-55dd-45d6-b709-92967e1605af"));

	public static readonly string Title = "Miss Hulk";
	public static readonly int StartingLife = 14;
	public static readonly int HandSize = 6;
	public static ICardSet Create() => new CardSet(CardSetId, true, false, false, "Miss Hulk", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = CardId, Classification = ClassificationEnum.Identity, Type = TypeEnum.Hero, CardSet = CardSetId, Title = "Miss Hulk" },
			new CollectibleCardDto() { Id = EntityId.Create("cebefc07-5f4b-434c-ab80-4ca990d52c1d"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Ally, CardSet = CardSetId, Title = "Hellcat" },
			new CollectibleCardDto() { Id = EntityId.Create("d7ccf8e6-ab15-4461-a455-f9d7a68098f4"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Gamma Slam" },
			new CollectibleCardDto() { Id = EntityId.Create("bc52f74e-15d1-4572-9f3a-a76457f56b72"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Ground Stomp" },
			new CollectibleCardDto() { Id = EntityId.Create("5da0af05-715a-4894-aae3-3771bc14f471"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Ground Stomp" },
			new CollectibleCardDto() { Id = EntityId.Create("52499956-fb7f-4671-827a-da0e950270ba"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Legal Practice" },
			new CollectibleCardDto() { Id = EntityId.Create("c59ea0ee-80fe-43a9-aeb3-efe9fd2ea3aa"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Legal Practice" },
			new CollectibleCardDto() { Id = EntityId.Create("e88acd91-b79a-4b7b-9334-ebd9451806a0"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "One-Two Punch" },
			new CollectibleCardDto() { Id = EntityId.Create("a4543b45-fdc7-4bb1-a359-c50b9adfd7c9"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "One-Two Punch" },
			new CollectibleCardDto() { Id = EntityId.Create("89785e67-be53-440b-99b0-9b0f9413affa"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "One-Two Punch" },
			new CollectibleCardDto() { Id = EntityId.Create("3bc34351-1cda-4cf5-a141-c19bd049fb45"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Split Personality" },
			new CollectibleCardDto() { Id = EntityId.Create("d298b7e6-5e1c-4b0e-8da1-383b404d874f"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Support, CardSet = CardSetId, Title = "Superhuman Law Division" },
			new CollectibleCardDto() { Id = EntityId.Create("6da98878-b880-4bd0-b022-eb42db25075a"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Focused Rage" },
			new CollectibleCardDto() { Id = EntityId.Create("e251d0fd-d3b4-4276-ab7d-76dc4d94a8aa"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Focused Rage" },
			new CollectibleCardDto() { Id = EntityId.Create("ba25e1f2-c6eb-4dd9-aaa6-280db3dae458"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Superhuman Strength" },
			new CollectibleCardDto() { Id = EntityId.Create("63554f01-b882-4c71-b248-5e34e508c1a0"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Superhuman Strength" },
			new CollectibleCardDto() { Id = EntityId.Create("06857574-ed80-440f-92f3-55261eaa5bed"), Classification = ClassificationEnum.Identity, Type = TypeEnum.Obligation, CardSet = CardSetId, Title = "Legal Work" },
		});
	public static ICardSet CreateNemesis() => new CardSet(NemesisCardSetId, true, true, false, "Miss Hulk Nemesis", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("74e68f6e-5d68-494f-b7b8-0d1af8e3bc40"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.SideScheme, CardSet = NemesisCardSetId, Title = "Personal Challenge" },
			new CollectibleCardDto() { Id = EntityId.Create("59435593-ede0-4e68-939d-dd3bc21d1498"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.Minion, CardSet = NemesisCardSetId, Title = "Titania" },
			new CollectibleCardDto() { Id = EntityId.Create("2b73096f-0911-4023-82cd-b2d7d0b1f8d6"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.Attachment, CardSet = NemesisCardSetId, Title = "Genetically Enhanced" },
			new CollectibleCardDto() { Id = EntityId.Create("7735b096-d2ef-40c6-9e7f-0fe45a5eae63"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.Treachery, CardSet = NemesisCardSetId, Title = "Titania's Fury" },
			new CollectibleCardDto() { Id = EntityId.Create("afc33132-881d-47af-8e9a-e9633618aa86"), Classification = ClassificationEnum.Nemesis, Type = TypeEnum.Treachery, CardSet = NemesisCardSetId, Title = "Titania's Fury" },
		});
}
