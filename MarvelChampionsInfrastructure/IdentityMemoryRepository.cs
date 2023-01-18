using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.ValueObjects;

using MarvelChampionsInfrastructure.Data;

namespace MarvelChampionsInfrastructure;
public sealed class HeroIdentityMemoryRepository : BaseMemoryRepository<EntityId, IHeroIdentity>, IHeroIdentityRepository
{
	public HeroIdentityMemoryRepository() => Load();
	private void Load()
	{
		Create(
			CaptainMarvelDeckDtoFactory.IdentityId,
			new HeroIdentity(
				CaptainMarvelDeckDtoFactory.IdentityId,
				CaptainMarvelDeckDtoFactory.CardSetId,
				CaptainMarvelDeckDtoFactory.NemesisCardSetId,
				CaptainMarvelDeckDtoFactory.CardId,
				"Captain Marvel",
				12));
		Create(
			MissHulkDeckDtoFactory.IdentityId,
			new HeroIdentity(
				MissHulkDeckDtoFactory.IdentityId,
				MissHulkDeckDtoFactory.CardSetId,
				MissHulkDeckDtoFactory.NemesisCardSetId,
				MissHulkDeckDtoFactory.CardId,
				"Miss Hulk",
				14));
		Create(
			SpidermanDeckDtoFactory.IdentityId,
			new HeroIdentity(
				SpidermanDeckDtoFactory.IdentityId,
				SpidermanDeckDtoFactory.CardSetId,
				SpidermanDeckDtoFactory.NemesisCardSetId,
				SpidermanDeckDtoFactory.CardId,
				"Spiderman",
				10));
		Create(
			IronManDeckDtoFactory.IdentityId,
			new HeroIdentity(
				IronManDeckDtoFactory.IdentityId,
				IronManDeckDtoFactory.CardSetId,
				IronManDeckDtoFactory.NemesisCardSetId,
				IronManDeckDtoFactory.CardId,
				"Iron Man",
				9));
		Create(
			BlackPantherDeckDtoFactory.IdentityId,
			new HeroIdentity(
				BlackPantherDeckDtoFactory.IdentityId,
				BlackPantherDeckDtoFactory.CardSetId,
				BlackPantherDeckDtoFactory.NemesisCardSetId,
				BlackPantherDeckDtoFactory.CardId,
				"Black Panther",
				11));
	}
}
