using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class TheMastersOfEvilDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create("a8a9316c-9332-482e-b8d3-23210169f056");
	public static ICardSet Create() => new CardSet(CardSetId, false, true, false, "The Masters of Evil", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("657e4dc2-980c-43b4-a6a4-44d6f2abb759"), Classification = ClassificationEnum.Modular, Type = TypeEnum.SideScheme, CardSet = CardSetId, Title = "The Masters of Evil" },
			new CollectibleCardDto() { Id = EntityId.Create("659ca620-740f-43fb-ae1d-7527a079eeba"), Classification = ClassificationEnum.Modular, Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Radioactive Man" },
			new CollectibleCardDto() { Id = EntityId.Create("fc5157c8-f7ed-4d23-84ab-2856af58670e"), Classification = ClassificationEnum.Modular, Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Whirlwind" },
			new CollectibleCardDto() { Id = EntityId.Create("26bbe34c-7b63-43a9-b7d5-c5f0ec71a2a4"), Classification = ClassificationEnum.Modular, Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Tiger Shark" },
			new CollectibleCardDto() { Id = EntityId.Create("10138710-9f16-454c-b5d5-9348d7368b54"), Classification = ClassificationEnum.Modular, Type = TypeEnum.Minion, CardSet = CardSetId, Title = "Melter" },
			new CollectibleCardDto() { Id = EntityId.Create("12dd5594-a4e7-47d1-a454-d2be438e223e"), Classification = ClassificationEnum.Modular, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Masters of Mayhem" },
			new CollectibleCardDto() { Id = EntityId.Create("5fc367f8-30dd-4102-9167-bd967eb8e80d"), Classification = ClassificationEnum.Modular, Type = TypeEnum.Treachery, CardSet = CardSetId, Title = "Masters of Mayhem" },
		});
}
