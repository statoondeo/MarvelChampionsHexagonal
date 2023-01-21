using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class BombScareDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create("e45419b2-8570-4b4c-98f1-30eacb8441f6");
	public static ICardSet Create() => new CardSet(CardSetId, false, true, false, "Bomb Scare", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("c18d3ac2-d156-4973-a561-4f531ca35a80"), Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "Bomb Scare" },
			new CollectibleCardDto() { Id = EntityId.Create("4d74730d-6240-43a6-9bea-269225ee1bfb"), Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Hydra Bomber" },
			new CollectibleCardDto() { Id = EntityId.Create("e2c10ad9-87ad-40be-b3ee-348b16418349"), Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Hydra Bomber" },
			new CollectibleCardDto() { Id = EntityId.Create("2d58ab8b-ddfb-4d32-9d0a-5f4fd174a059"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Explosion" },
			new CollectibleCardDto() { Id = EntityId.Create("2d835e24-893d-4ff0-85ee-3fc3779551c4"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "False Alarm" },
			new CollectibleCardDto() { Id = EntityId.Create("fc558ec9-2d8b-488e-8d6a-6fa314e89e26"), Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "False Alarm" },
		});
}
