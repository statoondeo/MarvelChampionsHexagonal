using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsInfrastructure.Data;

public static class BlackPantherDeckDtoFactory
{
	public static readonly EntityId IdentityId = EntityId.Create(new Guid("eb2cbcaa-505e-4ced-937b-0485e6ade130"));
	public static readonly EntityId CardSetId = EntityId.Create(new Guid("84f09e90-5f99-42f2-ab34-87422f6a7325"));
	public static ICardSet Create() => new CardSet(true, "Black Panther", new List<CollectibleCardDto>()
		{
			new CollectibleCardDto() { Id = IdentityId, Title = "Black Panther" },
		});
}
