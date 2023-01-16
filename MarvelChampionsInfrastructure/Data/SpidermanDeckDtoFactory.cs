using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class SpidermanDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("df8cf2b9-32ac-4af9-be79-8fe98bde62f8"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("e4d9a052-e79e-43a2-af88-9d77360b858c"));
	public static ICardSet Create() => new CardSet(true, "Spiderman", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId, Title = "Spiderman" },
		});
}
