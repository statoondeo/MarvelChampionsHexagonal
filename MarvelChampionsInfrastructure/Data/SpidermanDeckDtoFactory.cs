using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class SpidermanDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("df8cf2b9-32ac-4af9-be79-8fe98bde62f8"));
	public static readonly EntityId CardId = EntityId.Create(new Guid("0956909b-3a72-48e7-8a84-665beb87a369"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("e4d9a052-e79e-43a2-af88-9d77360b858c"));
	public static readonly EntityId NemesisCardSetId = EntityId.Create(new Guid("291ed711-1154-4fa2-ac72-1529e4051efc"));
	public static ICardSet Create() => new CardSet(CardSetId, true, false, false, "Spiderman", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = CardId, Type = TypeEnum.Ally, CardSet = CardSetId, Title = "Spiderman" },
			new CollectibleCardDto() { Id = EntityId.Create("11dabc0d-e242-4bf8-8e7f-b2fcc7170cd0"), Type = TypeEnum.Ally, CardSet = CardSetId, Title = "Black Cat" },
			new CollectibleCardDto() { Id = EntityId.Create("f348d1ed-cf96-4a8e-9028-b396b3c43a50"), Type = TypeEnum.Event, CardSet = CardSetId, Title = "Backflip" },
			new CollectibleCardDto() { Id = EntityId.Create("e1a30d7b-f3c7-412e-83cb-184d6c5ab21e"), Type = TypeEnum.Event, CardSet = CardSetId, Title = "Backflip" },
			new CollectibleCardDto() { Id = EntityId.Create("668341f1-2d07-4d45-aa64-6c2a24c93a14"), Type = TypeEnum.Event, CardSet = CardSetId, Title = "Enhanced Spider-Sense" },
			new CollectibleCardDto() { Id = EntityId.Create("fad37c9b-aa76-4a28-ac4b-574a92873ce2"), Type = TypeEnum.Event, CardSet = CardSetId, Title = "Enhanced Spider-Sense" },
			new CollectibleCardDto() { Id = EntityId.Create("c04296ed-bb36-4ca4-9eae-efbedbfb08f8"), Type = TypeEnum.Event, CardSet = CardSetId, Title = "Swinging Web Kick" },
			new CollectibleCardDto() { Id = EntityId.Create("f9bd8dde-b589-4e99-9446-2b6e6848fa01"), Type = TypeEnum.Event, CardSet = CardSetId, Title = "Swinging Web Kick" },
			new CollectibleCardDto() { Id = EntityId.Create("23a26015-53be-4a9c-99cc-19813105dd8d"), Type = TypeEnum.Event, CardSet = CardSetId, Title = "Swinging Web Kick" },
			new CollectibleCardDto() { Id = EntityId.Create("5bbc7681-bef4-406e-b2a0-85654e08c7b1"), Type = TypeEnum.Support, CardSet = CardSetId, Title = "Aunt May" },
			new CollectibleCardDto() { Id = EntityId.Create("b5615db3-3c02-421e-a30a-bf8d4c133419"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Spider-Tracer" },
			new CollectibleCardDto() { Id = EntityId.Create("edac7633-6337-4976-b1de-98a91d25e967"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Spider-Tracer" },
			new CollectibleCardDto() { Id = EntityId.Create("8e911300-8c65-40ef-8d16-7b0eb1b3dc66"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Web-Shooter" },
			new CollectibleCardDto() { Id = EntityId.Create("a8f77fea-52b2-4115-9f8d-30c8c1109c1a"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Web-Shooter" },
			new CollectibleCardDto() { Id = EntityId.Create("4cbc0097-0f04-4dd6-85c5-ea1192095b1f"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Webbed Up" },
			new CollectibleCardDto() { Id = EntityId.Create("22e0d5a7-b9f0-46b1-a7fc-4b7ee6b49eab"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Webbed Up" },
			new CollectibleCardDto() { Id = EntityId.Create("33948eb7-8040-4294-baf0-f0f09e1b8c52"), Type = TypeEnum.Obligation, CardSet = CardSetId, Title = "Eviction Notice" },
		});
	public static ICardSet CreateNemesis() => new CardSet(NemesisCardSetId, true, true, false, "Spiderman Nemesis", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("476ddc28-4aa5-4d20-9953-98326259b47e"), Type = TypeEnum.SideScheme, CardSet = NemesisCardSetId, Title = "Highway Robbery" },
			new CollectibleCardDto() { Id = EntityId.Create("28c260e4-4760-49de-8812-39b320330591"), Type = TypeEnum.Minion, CardSet = NemesisCardSetId, Title = "Vulture" },
			new CollectibleCardDto() { Id = EntityId.Create("32f2ea74-b0be-4ba5-bbb1-666ac67f566d"), Type = TypeEnum.Treachery, CardSet = NemesisCardSetId, Title = "Sweeping Swoop" },
			new CollectibleCardDto() { Id = EntityId.Create("86c9c7ac-d5d4-49e7-85bf-8888957fdeed"), Type = TypeEnum.Treachery, CardSet = NemesisCardSetId, Title = "Sweeping Swoop" },
			new CollectibleCardDto() { Id = EntityId.Create("3324f62a-0625-42f4-b59b-251a96b5f245"), Type = TypeEnum.Treachery, CardSet = NemesisCardSetId, Title = "The Vulture's Plans" },
		});
}
