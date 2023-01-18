using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.ValueObjects;

using MarvelChampionsInfrastructure.Data;

namespace MarvelChampionsInfrastructure;

public sealed class VillainIdentityMemoryRepository : BaseMemoryRepository<EntityId, IVillainIdentity>, IVillainIdentityRepository
{
	public VillainIdentityMemoryRepository() => Load();
	private void Load()
	{
		Create(
			RhinoDeckDtoFactory.IdentityId1,
			new VillainIdentity(
				RhinoDeckDtoFactory.CardSetId,
				RhinoDeckDtoFactory.StandardIdentitySet,
				RhinoDeckDtoFactory.SchemeCardSetId,
				StandardDeckDtoFactory.CardSetId,
				"Rhino Standard",
				14));
		Create(
			RhinoDeckDtoFactory.IdentityId2,
			new VillainIdentity(
				RhinoDeckDtoFactory.CardSetId,
				RhinoDeckDtoFactory.ExpertIdentitySet,
				RhinoDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				"Rhino Expert",
				15));
		Create(
			KlawDeckDtoFactory.IdentityId1,
			new VillainIdentity(
				KlawDeckDtoFactory.CardSetId,
				KlawDeckDtoFactory.StandardIdentitySet,
				KlawDeckDtoFactory.SchemeCardSetId,
				StandardDeckDtoFactory.CardSetId,
				"Klaw Standard",
				12));
		Create(
			KlawDeckDtoFactory.IdentityId2,
			new VillainIdentity(
				KlawDeckDtoFactory.CardSetId,
				KlawDeckDtoFactory.ExpertIdentitySet,
				KlawDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				"Klaw Expert",
				18));
		Create(
			UltronDeckDtoFactory.IdentityId1,
			new VillainIdentity(
				UltronDeckDtoFactory.CardSetId,
				UltronDeckDtoFactory.StandardIdentitySet,
				UltronDeckDtoFactory.SchemeCardSetId,
				StandardDeckDtoFactory.CardSetId,
				"Ultron Standard",
				17));
		Create(
			UltronDeckDtoFactory.IdentityId2,
			new VillainIdentity(
				UltronDeckDtoFactory.CardSetId,
				UltronDeckDtoFactory.ExpertIdentitySet,
				UltronDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				"Ultron Expert",
				22));
	}
}
