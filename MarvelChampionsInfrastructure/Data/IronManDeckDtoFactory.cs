using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class IronManDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("59e21cf9-a98c-40c4-b041-5757481ec7a2"));
	public static readonly EntityId CardId = EntityId.Create(new Guid("de7fe95f-40df-48bd-b70f-601b455fdf3a"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("1e0b1de5-e3d2-44ec-9266-f09fc9e13b01"));
	public static readonly EntityId NemesisCardSetId = EntityId.Create(new Guid("29b19733-b0b1-41d5-8060-d35ec2d1b546"));
	public static ICardSet Create() => new CardSet(CardSetId, true, false, false, "Iron Man", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = CardId, CardSet = CardSetId, Title = "Iron Man" },
			new CollectibleCardDto() { Id = EntityId.Create("fd90b37d-a164-478a-b157-923207b5a281"), CardSet = CardSetId, Title = "War Machine" },
			new CollectibleCardDto() { Id = EntityId.Create("36175d81-ea0f-45ab-8a77-a6e87ce3e56d"), CardSet = CardSetId, Title = "Repulsor Blast" },
			new CollectibleCardDto() { Id = EntityId.Create("08443c40-361a-4814-9c41-74098d52ea8e"), CardSet = CardSetId, Title = "Repulsor Blast" },
			new CollectibleCardDto() { Id = EntityId.Create("c951d9fa-6617-40c6-9093-1dda64cc213f"), CardSet = CardSetId, Title = "Repulsor Blast" },
			new CollectibleCardDto() { Id = EntityId.Create("c94e374f-ecd2-4d7b-b5aa-9781161ccbab"), CardSet = CardSetId, Title = "Supersonic Punch" },
			new CollectibleCardDto() { Id = EntityId.Create("7974956a-50a5-4405-b7e1-e756466c2f7c"), CardSet = CardSetId, Title = "Supersonic Punch" },
			new CollectibleCardDto() { Id = EntityId.Create("046b4680-5df8-4b52-a218-d76d9fa0393f"), CardSet = CardSetId, Title = "Pepper Potts" },
			new CollectibleCardDto() { Id = EntityId.Create("6bb7fc52-b793-4119-aaa8-eeddfd37afe9"), CardSet = CardSetId, Title = "Stark Tower" },
			new CollectibleCardDto() { Id = EntityId.Create("4f9884e1-f431-4ee5-95d9-a91c0b9e730c"), CardSet = CardSetId, Title = "Arc Reactor" },
			new CollectibleCardDto() { Id = EntityId.Create("3dd3a3d8-aac7-4bf5-92d4-df7b30ed7ea9"), CardSet = CardSetId, Title = "Mark V Armor" },
			new CollectibleCardDto() { Id = EntityId.Create("4970ba93-3fe4-4f4d-b861-53f69fc71893"), CardSet = CardSetId, Title = "Mark V Helmet" },
			new CollectibleCardDto() { Id = EntityId.Create("e8809a66-0ee8-416f-9310-61b119c337e7"), CardSet = CardSetId, Title = "Powered Gauntlets" },
			new CollectibleCardDto() { Id = EntityId.Create("b053acc3-8296-4570-b4c8-d7c7ae3936c0"), CardSet = CardSetId, Title = "Rocket Boots" },
			new CollectibleCardDto() { Id = EntityId.Create("76172a2f-83c7-419a-8082-57b85a5ed162"), CardSet = CardSetId, Title = "Rocket Boots" },
			new CollectibleCardDto() { Id = EntityId.Create("1a7f0842-d7f7-472d-a60e-d7c8f72b9a4f"), CardSet = CardSetId, Title = "Business Problems" },
			
			new CollectibleCardDto() { Id = EntityId.Create("edcd6c79-8500-4660-8f07-00be538f323b"), CardSet = NemesisCardSetId, Title = "Imminent Overload" },
			new CollectibleCardDto() { Id = EntityId.Create("de7c2381-319d-4ab5-a66e-ee4497b14a6e"), CardSet = NemesisCardSetId, Title = "Whiplash" },
			new CollectibleCardDto() { Id = EntityId.Create("f566ebf4-5184-4611-a455-a7bbf581cf81"), CardSet = NemesisCardSetId, Title = "Electric Whip Attack" },
			new CollectibleCardDto() { Id = EntityId.Create("ac55329d-84ee-4956-b60f-73bb5c7fb28f"), CardSet = NemesisCardSetId, Title = "Electric Whip Attack" },
			new CollectibleCardDto() { Id = EntityId.Create("5bb9fd24-58d6-44bd-8891-7032b356bfc0"), CardSet = NemesisCardSetId, Title = "Electromagnetic Backlash" },
		});
}
