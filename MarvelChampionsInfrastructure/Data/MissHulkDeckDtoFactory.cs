using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class MissHulkDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("ee99fc6f-7983-48a3-8603-5e2d760d11a6"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("085c8c14-fbfd-4661-b081-7689240c09b6"));
	public static ICardSet Create() => new CardSet(true, "Miss Hulk", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId, Title = "Miss Hulk" },
		});
}
