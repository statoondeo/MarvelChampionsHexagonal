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
				RhinoDeckDtoFactory.StandardTitle,
				RhinoDeckDtoFactory.StandardStartingLife));
		Create(
			RhinoDeckDtoFactory.ExpertId,
			new VillainIdentity(
				RhinoDeckDtoFactory.ExpertId,
				RhinoDeckDtoFactory.CardSetId,
				RhinoDeckDtoFactory.ExpertIdentitySet,
				RhinoDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				RhinoDeckDtoFactory.ExpertTitle,
				RhinoDeckDtoFactory.ExpertStartingLife));
		Create(
			KlawDeckDtoFactory.StandardId,
			new VillainIdentity(
				KlawDeckDtoFactory.StandardId,
				KlawDeckDtoFactory.CardSetId,
				KlawDeckDtoFactory.StandardIdentitySet,
				KlawDeckDtoFactory.SchemeCardSetId,
				StandardDeckDtoFactory.CardSetId,
				KlawDeckDtoFactory.StandardTitle,
				KlawDeckDtoFactory.StandardStartingLife));
		Create(
			KlawDeckDtoFactory.ExpertId,
			new VillainIdentity(
				KlawDeckDtoFactory.ExpertId,
				KlawDeckDtoFactory.CardSetId,
				KlawDeckDtoFactory.ExpertIdentitySet,
				KlawDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				KlawDeckDtoFactory.ExpertTitle,
				KlawDeckDtoFactory.ExpertStartingLife));
		Create(
			UltronDeckDtoFactory.StandardId,
			new VillainIdentity(
				UltronDeckDtoFactory.StandardId,
				UltronDeckDtoFactory.CardSetId,
				UltronDeckDtoFactory.StandardIdentitySet,
				UltronDeckDtoFactory.SchemeCardSetId,
				StandardDeckDtoFactory.CardSetId,
				UltronDeckDtoFactory.StandardTitle,
				UltronDeckDtoFactory.StandardStartingLife));
		Create(
			UltronDeckDtoFactory.ExpertId,
			new VillainIdentity(
				UltronDeckDtoFactory.ExpertId,
				UltronDeckDtoFactory.CardSetId,
				UltronDeckDtoFactory.ExpertIdentitySet,
				UltronDeckDtoFactory.SchemeCardSetId,
				ExpertDeckDtoFactory.CardSetId,
				UltronDeckDtoFactory.ExpertTitle,
				UltronDeckDtoFactory.ExpertStartingLife));
	}
}
