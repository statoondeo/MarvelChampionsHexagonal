using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class RhinoDeckDtoFactory
{
	public static readonly EntityId StandardId = EntityId.Create("8072d77e-33c8-43aa-928a-dd2a8010c3ae");
	public static readonly EntityId ExpertId = EntityId.Create("d36fea03-30e1-4b0a-836e-122392352356");

	public static readonly EntityId IdentityId1 = EntityId.Create("ed36377f-f733-48d0-9570-b63ddaad3c28");
	public static readonly EntityId IdentityId2 = EntityId.Create("03229955-53f7-40e4-86ce-acb3ebb74b91");
	public static readonly EntityId IdentityId3 = EntityId.Create("6623f22e-f37d-4229-94b8-5116fc145e90");

	public static readonly EntityId StandardIdentitySet = EntityId.Create("709bb464-8602-4408-8201-abb6f72d782d");
	public static readonly EntityId ExpertIdentitySet = EntityId.Create("5161e6a6-4edf-48b9-9207-d13174857e32");
	public static readonly EntityId CardSetId = EntityId.Create("034be480-a43b-4808-8a9f-d7438ae5f88e");
	public static readonly EntityId SchemeCardSetId = EntityId.Create("0929c3b0-07b6-4e22-9dc0-bb6e2b1f1e11");
	public static ICardSet CreateStandard() => new CardSet(StandardIdentitySet, true, true, false, "Rhino Standard", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId1, Type = TypeEnum.Villain, CardSet = StandardIdentitySet, Title = "Rhino 1" },
			new CollectibleCardDto() { Id = IdentityId2, Type = TypeEnum.Villain, CardSet = StandardIdentitySet, Title = "Rhino 2" },
		}); 
	public static ICardSet CreateExpert() => new CardSet(ExpertIdentitySet, true, true, false, "Rhino Expert", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId2, Type = TypeEnum.Villain, CardSet = ExpertIdentitySet, Title = "Rhino 2" },
			new CollectibleCardDto() { Id = IdentityId3, Type = TypeEnum.Villain, CardSet = ExpertIdentitySet, Title = "Rhino 3" },
		});
	public static ICardSet CreateDeck() => new CardSet(CardSetId, true, true, false, "Rhino Deck", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("11f61a3d-0355-4348-9515-4b8b91231a4f"), Type = TypeEnum.Attachment, CardSet = CardSetId, Title = "Armored Rhino Suit" },
			new CollectibleCardDto() { Id = EntityId.Create("d9efd202-8c9d-404a-a12a-3d3892628ceb"), Type = TypeEnum.Attachment, CardSet = CardSetId, Title = "Charge" },
			new CollectibleCardDto() { Id = EntityId.Create("6f8d5a7f-5c93-426b-900b-931ce5a41343"), Type = TypeEnum.Attachment, CardSet = CardSetId, Title = "Charge" },
			new CollectibleCardDto() { Id = EntityId.Create("e70a9ffa-1d34-4e55-b8c5-da2ef1aa446f"), Type = TypeEnum.Attachment, CardSet = CardSetId, Title = "Enhanced Ivory Horn" },
			new CollectibleCardDto() { Id = EntityId.Create("3e0f3718-490d-436e-92c0-09fb7c5a9e80"), Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Hydra Mercenary" },
			new CollectibleCardDto() { Id = EntityId.Create("3abf8fa9-8f2a-482c-a084-6ac46fe0884a"), Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Hydra Mercenary" },
			new CollectibleCardDto() { Id = EntityId.Create("42a7d7e0-18c0-4d14-b374-fe8694cbeda3"), Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Sandman" },
			new CollectibleCardDto() { Id = EntityId.Create("c6cb5c7b-7d90-4040-8474-1e87169a7f73"), Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Shocker" },
			new CollectibleCardDto() { Id = EntityId.Create("9c537281-d5d4-45e7-a0b7-bfc254645797"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Hard to Keep Down" },
			new CollectibleCardDto() { Id = EntityId.Create("04f71e0d-2d15-473b-a0e6-17d06560c83a"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Hard to Keep Down" },
			new CollectibleCardDto() { Id = EntityId.Create("21e573f4-07da-422d-8480-6527cdf552fc"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "\"I'm Tough\"" },
			new CollectibleCardDto() { Id = EntityId.Create("80386034-bab0-4407-b414-bf2318906253"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "\"I'm Tough\"" },
			new CollectibleCardDto() { Id = EntityId.Create("0d7594fb-f1d2-4331-bd55-5e3794cca088"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Stampede" },
			new CollectibleCardDto() { Id = EntityId.Create("9c5675a0-00c4-4a7f-ba1f-ccea3ba0a60e"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Stampede" },
			new CollectibleCardDto() { Id = EntityId.Create("c28ddd9e-0df6-4e75-95bf-71e040d8720f"), Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "Breakin' & Takin'" },
			new CollectibleCardDto() { Id = EntityId.Create("3a4c6e3e-a9f9-48db-9d60-fa714b609a32"), Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "Crowd Control" },
		});
	public static ICardSet CreateScheme() => new CardSet(SchemeCardSetId, true, true, false, "Rhino Scheme", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("f381f19a-a450-49eb-90df-6822c9ad445d"), Type = TypeEnum.MainSchemeA, CardSet = SchemeCardSetId, Title = "The Break-In! - 1A" },
			new CollectibleCardDto() { Id = EntityId.Create("a458c7ff-0c75-48f9-8b65-6411a04e6c41"), Type = TypeEnum.MainSchemeB, CardSet = SchemeCardSetId, Title = "The Break-In! - 1B" },
		});
}
