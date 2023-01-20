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
			RhinoDeckDtoFactory.StandardId,
			new VillainIdentity(
				RhinoDeckDtoFactory.StandardId,
				RhinoDeckDtoFactory.CardSetId,
				RhinoDeckDtoFactory.StandardIdentitySet,
				RhinoDeckDtoFactory.SchemeCardSetId,
				StandardDeckDtoFactory.CardSetId,
				"Rhino Standard",
				14));
		Create(
			RhinoDeckDtoFactory.ExpertId,
			new VillainIdentity(
				RhinoDeckDtoFactory.ExpertId,
				RhinoDeckDtoFactory.CardSetId,
				RhinoDeckDtoFactory.ExpertIdentitySet,
				RhinoDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				"Rhino Expert",
				15));
		Create(
			KlawDeckDtoFactory.StandardId,
			new VillainIdentity(
				KlawDeckDtoFactory.StandardId,
				KlawDeckDtoFactory.CardSetId,
				KlawDeckDtoFactory.StandardIdentitySet,
				KlawDeckDtoFactory.SchemeCardSetId,
				StandardDeckDtoFactory.CardSetId,
				"Klaw Standard",
				12));
		Create(
			KlawDeckDtoFactory.ExpertId,
			new VillainIdentity(
				KlawDeckDtoFactory.ExpertId,
				KlawDeckDtoFactory.CardSetId,
				KlawDeckDtoFactory.ExpertIdentitySet,
				KlawDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				"Klaw Expert",
				18));
		Create(
			UltronDeckDtoFactory.StandardId,
			new VillainIdentity(
				UltronDeckDtoFactory.StandardId,
				UltronDeckDtoFactory.CardSetId,
				UltronDeckDtoFactory.StandardIdentitySet,
				UltronDeckDtoFactory.SchemeCardSetId,
				StandardDeckDtoFactory.CardSetId,
				"Ultron Standard",
				17));
		Create(
			UltronDeckDtoFactory.ExpertId,
			new VillainIdentity(
				UltronDeckDtoFactory.ExpertId,
				UltronDeckDtoFactory.CardSetId,
				UltronDeckDtoFactory.ExpertIdentitySet,
				UltronDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				"Ultron Expert",
				22));
	}
}
