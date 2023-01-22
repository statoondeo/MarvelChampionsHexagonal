using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class StandardDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create("b93afe36-9002-445c-9c11-b7e2534e3447");
	public static ICardSet Create() => new CardSet(CardSetId, false, true, true, "Standard from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("0e439f9e-2e7e-4eb0-9970-afbfa18ac858"), Classification = ClassificationEnum.Standard, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Advance" },
			new CollectibleCardDto() { Id = EntityId.Create("1681d8d6-56fb-4a2f-93db-00aa7a72de68"), Classification = ClassificationEnum.Standard, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Advance" },
			new CollectibleCardDto() { Id = EntityId.Create("6e9310e9-fbda-454f-9be2-e5bad46d7602"), Classification = ClassificationEnum.Standard, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Assault" },
			new CollectibleCardDto() { Id = EntityId.Create("6b50bc5c-1306-4540-8778-c619cb0c79e0"), Classification = ClassificationEnum.Standard, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Assault" },
			new CollectibleCardDto() { Id = EntityId.Create("c23601f9-3f1f-48dc-b67c-a19caf2dd766"), Classification = ClassificationEnum.Standard, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Shadow of The past" },
			new CollectibleCardDto() { Id = EntityId.Create("7310ad60-bab2-4558-9f19-84282180230b"), Classification = ClassificationEnum.Standard, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Gang Up" },
			new CollectibleCardDto() { Id = EntityId.Create("41626601-82f9-4cd0-a5da-1c27b9b28d4a"), Classification = ClassificationEnum.Standard, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Caught Off Guard" },
		});
}
