using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class TheDoomsdayChairDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create("eb518080-4bdb-4a7b-9501-013cc3207266");
	public static ICardSet Create() => new CardSet(CardSetId,false, true, false, "The Doomsday Chair", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("62b95a10-f6b3-4349-8f3c-cfe08ac7a30a"), Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "The Doomsday Chair" },
			new CollectibleCardDto() { Id = EntityId.Create("10540d6c-284a-4615-bc3f-2c769d7310d5"), Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "The Doomsday Chair" },
			new CollectibleCardDto() { Id = EntityId.Create("bde1beb5-bd60-4781-a1bc-ed5e0f50a1a6"), Type = TypeEnum.Minion, CardSet = CardSetId, Title = "MODOK" },
			new CollectibleCardDto() { Id = EntityId.Create("6a3d99ee-20eb-426e-b601-e2563300705f"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Biomechanical Upgrades" },
			new CollectibleCardDto() { Id = EntityId.Create("a29eae67-2230-4174-ac15-e356af8325fe"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Biomechanical Upgrades" },
			new CollectibleCardDto() { Id = EntityId.Create("1428f325-3d47-430d-9499-09dc599b3913"), Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Biomechanical Upgrades" },
		});
}
