using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class AggressionDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create("51d4a931-d01c-4366-a4da-78696eeaa8e2");
	public static ICardSet Create() => new CardSet(CardSetId, false, false, false, "Aggression", new List<CollectibleCardDto>()
		{
			new CollectibleCardBuilder()
				.WithId(EntityId.Create("a182dee3-60f6-43d1-b77b-058902767a61"))		
				.WithTitle("Hulk")
				.WithCardSet(CardSetId)
				.WithType(TypeEnum.Ally)
				.WithClassification(ClassificationEnum.Aggression)
				.Build(),

			//new CollectibleCardDto() { Id = EntityId.Create("a182dee3-60f6-43d1-b77b-058902767a61"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Ally, CardSet = CardSetId, Title = "Hulk" },
			new CollectibleCardDto() { Id = EntityId.Create("fdb46dda-4b6b-4875-a94c-2bf8d522b6a9"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Ally, CardSet = CardSetId, Title = "Tigra" },
			new CollectibleCardDto() { Id = EntityId.Create("d9790ff7-bfd6-4bfc-9a6b-446394edcef9"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Chase Them Down" },
			new CollectibleCardDto() { Id = EntityId.Create("486736c1-fe0d-4a6b-89df-cb68f06b3392"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Chase Them Down" },
			new CollectibleCardDto() { Id = EntityId.Create("58f3704a-734f-4ac9-93b6-b7d7a245641b"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Relentless Assault" },
			new CollectibleCardDto() { Id = EntityId.Create("1158ce3e-7b0a-4bd8-958d-bb27409fb21d"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Relentless Assault" },
			new CollectibleCardDto() { Id = EntityId.Create("a8206d6a-bb17-4455-9d4f-841d1421883b"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Uppercut" },
			new CollectibleCardDto() { Id = EntityId.Create("a40fbd48-7496-49f7-bd72-87c85103a773"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Event, CardSet = CardSetId, Title = "Uppercut" },
			new CollectibleCardDto() { Id = EntityId.Create("c3e79034-7e4b-47ea-a4e3-88bab11947ae"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Resource, CardSet = CardSetId, Title = "The Power Of Aggression" },
			new CollectibleCardDto() { Id = EntityId.Create("12ab532d-80d5-4e7c-8528-4b473b304880"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Resource, CardSet = CardSetId, Title = "The Power Of Aggression" },
			new CollectibleCardDto() { Id = EntityId.Create("46491b43-41fe-4831-8946-88954c558549"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Support, CardSet = CardSetId, Title = "Tac Team" },
			new CollectibleCardDto() { Id = EntityId.Create("ed810061-cd92-4b10-bfb8-624111bcc2bc"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Support, CardSet = CardSetId, Title = "Tac Team" },
			new CollectibleCardDto() { Id = EntityId.Create("9af48a58-a9cc-4d46-9ec4-a457590d05b2"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Combat Training" },
			new CollectibleCardDto() { Id = EntityId.Create("806977a7-26be-4a8e-9ced-f0b7fb6c159b"), Classification = ClassificationEnum.Aggression, Type = TypeEnum.Upgrade, CardSet = CardSetId, Title = "Combat Training" }
		});
}
