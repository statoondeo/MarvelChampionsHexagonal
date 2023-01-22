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
				CaptainMarvelDeckDtoFactory.Title,
				CaptainMarvelDeckDtoFactory.StartingLife,
				CaptainMarvelDeckDtoFactory.HandSize));
		Create(
			MissHulkDeckDtoFactory.IdentityId,
			new HeroIdentity(
				MissHulkDeckDtoFactory.IdentityId,
				MissHulkDeckDtoFactory.CardSetId,
				MissHulkDeckDtoFactory.NemesisCardSetId,
				MissHulkDeckDtoFactory.CardId,
				MissHulkDeckDtoFactory.Title,
				MissHulkDeckDtoFactory.StartingLife,
				MissHulkDeckDtoFactory.HandSize));
		Create(
			SpidermanDeckDtoFactory.IdentityId,
			new HeroIdentity(
				SpidermanDeckDtoFactory.IdentityId,
				SpidermanDeckDtoFactory.CardSetId,
				SpidermanDeckDtoFactory.NemesisCardSetId,
				SpidermanDeckDtoFactory.CardId,
				SpidermanDeckDtoFactory.Title,
				SpidermanDeckDtoFactory.StartingLife,
				SpidermanDeckDtoFactory.HandSize));
		Create(
			IronManDeckDtoFactory.IdentityId,
			new HeroIdentity(
				IronManDeckDtoFactory.IdentityId,
				IronManDeckDtoFactory.CardSetId,
				IronManDeckDtoFactory.NemesisCardSetId,
				IronManDeckDtoFactory.CardId,
				IronManDeckDtoFactory.Title,
				IronManDeckDtoFactory.StartingLife,
				IronManDeckDtoFactory.HandSize));
		Create(
			BlackPantherDeckDtoFactory.IdentityId,
			new HeroIdentity(
				BlackPantherDeckDtoFactory.IdentityId,
				BlackPantherDeckDtoFactory.CardSetId,
				BlackPantherDeckDtoFactory.NemesisCardSetId,
				BlackPantherDeckDtoFactory.CardId,
				BlackPantherDeckDtoFactory.Title,
				BlackPantherDeckDtoFactory.StartingLife,
				BlackPantherDeckDtoFactory.HandSize));
	}
}
