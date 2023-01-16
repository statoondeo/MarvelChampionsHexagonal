using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.ValueObjects;

using MarvelChampionsInfrastructure.Data;

namespace MarvelChampionsInfrastructure;

public sealed class IdentityMemoryRepository : BaseRepository<EntityId, IIdentity>, IIdentityRepository
{
	public IdentityMemoryRepository() => Load();
	private void Load()
	{
		Create(
			CaptainMarvelDeckDtoFactory.IdentityId,
			 new Identity(
				 CaptainMarvelDeckDtoFactory.IdentityId,
				 CaptainMarvelDeckDtoFactory.CardSetId,
				   "Captain Marvel",
					 12));
		Create(
			MissHulkDeckDtoFactory.IdentityId,
			new Identity(
				MissHulkDeckDtoFactory.IdentityId,
				MissHulkDeckDtoFactory.CardSetId,
				"Miss Hulk",
				  14));
		Create(
			SpidermanDeckDtoFactory.IdentityId,
			 new Identity(
				 SpidermanDeckDtoFactory.IdentityId,
				 SpidermanDeckDtoFactory.CardSetId,
				   "Spiderman",
					10));
		Create(
			IronManDeckDtoFactory.IdentityId,
			   new Identity(
				 IronManDeckDtoFactory.IdentityId,
				 IronManDeckDtoFactory.CardSetId,
					 "Iron Man",
					   9));
		Create(
			BlackPantherDeckDtoFactory.IdentityId,
			new Identity(
				BlackPantherDeckDtoFactory.IdentityId,
				BlackPantherDeckDtoFactory.CardSetId,
				"Black Panther",
				  11));
	}
}
