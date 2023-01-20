using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class BasicDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("594f6dda-4146-40c7-bc67-8cdf939dc05d"));
	public static ICardSet Create() => new CardSet(CardSetId, false, false, false, "Basic from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("2043f2e5-10c6-4e60-9898-c53d2a2bf9ed"), CardSet = CardSetId, Title = "Mockingbird" },
			new CollectibleCardDto() { Id = EntityId.Create("43f1c3cc-a763-4a5d-a190-449188639b54"), CardSet = CardSetId, Title = "Nick Fury" },
			new CollectibleCardDto() { Id = EntityId.Create("9b425f75-1800-4426-b206-253d0638f87c"), CardSet = CardSetId, Title = "Emergency" },
			new CollectibleCardDto() { Id = EntityId.Create("3b2dc85c-0b5d-468c-9f9b-ee0052e8c9c9"), CardSet = CardSetId, Title = "First Aid" },
			new CollectibleCardDto() { Id = EntityId.Create("5a658d87-a68e-4f6c-9c5a-9702f9206e8f"), CardSet = CardSetId, Title = "Haymaker" },
			new CollectibleCardDto() { Id = EntityId.Create("dd7e3663-5ae5-418f-b5b1-cb6717d61b8b"), CardSet = CardSetId, Title = "Energy" },
			new CollectibleCardDto() { Id = EntityId.Create("b8e65356-e94a-4086-a3cf-8f0adcd0cb58"), CardSet = CardSetId, Title = "Genius" },
			new CollectibleCardDto() { Id = EntityId.Create("f59c757e-e836-41cf-959f-1d2ca813f549"), CardSet = CardSetId, Title = "Strength" },
			new CollectibleCardDto() { Id = EntityId.Create("9b78ebfd-5603-46a8-a13c-06baaa89e7fb"), CardSet = CardSetId, Title = "Avengers Mansion" },
			new CollectibleCardDto() { Id = EntityId.Create("972f2cb9-e9e8-47dd-b6d0-bad3891cf6ac"), CardSet = CardSetId, Title = "Helicarrier" },
			new CollectibleCardDto() { Id = EntityId.Create("1ae77423-7d57-437a-9492-565591f8ae42"), CardSet = CardSetId, Title = "Tenacity" },
		});
}
