using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class ExpertDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create("4b709309-984a-4344-b658-c58a2b30a825");
	public static ICardSet Create() => new CardSet(false, true, "Expert from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("33667ba9-c913-4261-9c6e-38a07e3c78be"), CardSet = CardSetId, Title = "Advance" },
			new CollectibleCardDto() { Id = EntityId.Create("a9e63b08-0ae9-4810-a5ab-c22b61e132ae"), CardSet = CardSetId, Title = "Advance" },
			new CollectibleCardDto() { Id = EntityId.Create("288e5439-0684-45e4-891d-7bee65635b47"), CardSet = CardSetId, Title = "Assault" },
			new CollectibleCardDto() { Id = EntityId.Create("43187706-25db-4898-b7c7-efce906900a6"), CardSet = CardSetId, Title = "Assault" },
			new CollectibleCardDto() { Id = EntityId.Create("7dc15b7b-db64-434b-9fbe-f86740cf89a7"), CardSet = CardSetId, Title = "Shadow of The past" },
			new CollectibleCardDto() { Id = EntityId.Create("4c8a3858-881e-4f17-b206-0cae8aaecf47"), CardSet = CardSetId, Title = "Gang Up" },
			new CollectibleCardDto() { Id = EntityId.Create("bcb85c05-a309-4685-8038-402973e7dd86"), CardSet = CardSetId, Title = "Caught Off Guard" },
			new CollectibleCardDto() { Id = EntityId.Create("f360d5bc-2a92-439e-913b-35bf723cccb7"), CardSet = CardSetId, Title = "Under Fire" },
			new CollectibleCardDto() { Id = EntityId.Create("49c88a64-99cc-4b1a-8fa9-22e6f97cde0f"), CardSet = CardSetId, Title = "Masterplan" },
			new CollectibleCardDto() { Id = EntityId.Create("e5341d23-310d-4e03-91ef-43c241feddc3"), CardSet = CardSetId, Title = "Exhaustion" },
		});
}
