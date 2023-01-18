using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class UnderAttackDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create("d2ffc010-d3ef-436a-a8ee-d917438334bf");
	public static ICardSet Create() => new CardSet(false, true, "Under Attack", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("9f27254a-7106-472c-a0f8-151e44a9bd91"), CardSet = CardSetId, Title = "Under Attack" },
			new CollectibleCardDto() { Id = EntityId.Create("86937590-5f6b-4b60-b2d8-039db9d4793d"), CardSet = CardSetId, Title = "Vibranium Armor" },
			new CollectibleCardDto() { Id = EntityId.Create("c8d5a2c5-143d-4a02-833a-27c215928ebc"), CardSet = CardSetId, Title = "Concussion Blasters" },
			new CollectibleCardDto() { Id = EntityId.Create("6bafee20-f10f-4774-ac09-b1eed4daa9df"), CardSet = CardSetId, Title = "Concussive Blast" },
			new CollectibleCardDto() { Id = EntityId.Create("39d32897-20ff-4636-bfb5-e9f73b55533d"), CardSet = CardSetId, Title = "Concussive Blast" },
		});
}
