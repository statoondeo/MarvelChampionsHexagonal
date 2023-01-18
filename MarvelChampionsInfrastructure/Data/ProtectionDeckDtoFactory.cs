using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class ProtectionDeckDtoFactory
{
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("227edd54-803c-47e9-81bd-ac0b99a3750b"));
	public static ICardSet Create() => new CardSet(false, false, "Protection from CoreSet", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = EntityId.Create("bcae71be-8974-4344-86b0-ba39b20d35d6"), Title = "Black Widow" },
			new CollectibleCardDto() { Id = EntityId.Create("714cb7e6-c15d-4ca5-9292-0d13a5220818"), Title = "Luke Cage" },
			new CollectibleCardDto() { Id = EntityId.Create("6729decd-63e6-4dbd-ae41-3031fab1cf4c"), Title = "Counter Punch" },
			new CollectibleCardDto() { Id = EntityId.Create("cebabc82-08b9-4c86-b199-e476a73cd13c"), Title = "Counter Punch" },
			new CollectibleCardDto() { Id = EntityId.Create("a83b2ae0-e870-4ff7-b42b-b9b19fa40a70"), Title = "Get Behind Me" },
			new CollectibleCardDto() { Id = EntityId.Create("3c171305-63f5-4abc-a2f2-60450628921b"), Title = "Get Behind Me" },
			new CollectibleCardDto() { Id = EntityId.Create("eeba111d-5a8e-46bb-9e28-a5060875eacd"), Title = "The Power Of Protection" },
			new CollectibleCardDto() { Id = EntityId.Create("448cc4d4-2796-45ee-a093-e3f4d0631595"), Title = "The Power Of Protection" },
			new CollectibleCardDto() { Id = EntityId.Create("870a8805-b36b-4c28-b583-ba60c4069d76"), Title = "The Power Of Justice" },
			new CollectibleCardDto() { Id = EntityId.Create("1384e25e-ca7a-41ee-95a6-04d48fea2402"), Title = "Med Team" },
			new CollectibleCardDto() { Id = EntityId.Create("795114e8-147e-4c80-b3b4-93523fff3b59"), Title = "Med Team" },
			new CollectibleCardDto() { Id = EntityId.Create("a2edd77c-e9c6-48ea-9b71-e1adad5b686d"), Title = "Armored Vest" },
			new CollectibleCardDto() { Id = EntityId.Create("a7ed34ce-8656-45a7-ae9b-ca0f689232a7"), Title = "Armored Vest" },
			new CollectibleCardDto() { Id = EntityId.Create("f98c080f-4dc9-4099-bf03-b6b5e729ebca"), Title = "Indomitable" },
			new CollectibleCardDto() { Id = EntityId.Create("a153c3b0-8d75-4478-8073-5e4820d26737"), Title = "Indomitable" },
		});
}
