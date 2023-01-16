using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class IronManDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("59e21cf9-a98c-40c4-b041-5757481ec7a2"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("1e0b1de5-e3d2-44ec-9266-f09fc9e13b01"));
	public static ICardSet Create() => new CardSet(true, "Iron Man", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId, Title = "Iron Man" },
		});
}
