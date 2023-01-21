using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

using MarvelChampionsInfrastructure.Data;

namespace MarvelChampionsInfrastructure;

public sealed class MemoryCardSetRepository : BaseMemoryRepository<EntityId, ICardSet>, ICardSetRepository
{
	public MemoryCardSetRepository() => Load();
	private void Load()
	{
		ICardSet cardSet = AggressionDeckDtoFactory.Create();
		cardSet.Append(BasicDeckDtoFactory.Create());
		Create(cardSet.Id, cardSet);

		cardSet = JusticeDeckDtoFactory.Create();
		cardSet.Append(BasicDeckDtoFactory.Create());
		Create(cardSet.Id, cardSet);

		cardSet = LeadershipDeckDtoFactory.Create();
		cardSet.Append(BasicDeckDtoFactory.Create());
		Create(cardSet.Id, cardSet);

		cardSet = ProtectionDeckDtoFactory.Create();
		cardSet.Append(BasicDeckDtoFactory.Create());
		Create(cardSet.Id, cardSet);

		Create(CaptainMarvelDeckDtoFactory.CardSetId, CaptainMarvelDeckDtoFactory.Create());
		Create(CaptainMarvelDeckDtoFactory.NemesisCardSetId, CaptainMarvelDeckDtoFactory.CreateNemesis());

		Create(MissHulkDeckDtoFactory.CardSetId, MissHulkDeckDtoFactory.Create());
		Create(MissHulkDeckDtoFactory.NemesisCardSetId, MissHulkDeckDtoFactory.CreateNemesis());

		Create(BlackPantherDeckDtoFactory.CardSetId, BlackPantherDeckDtoFactory.Create());
		Create(BlackPantherDeckDtoFactory.NemesisCardSetId, BlackPantherDeckDtoFactory.CreateNemesis());

		Create(IronManDeckDtoFactory.CardSetId, IronManDeckDtoFactory.Create());
		Create(IronManDeckDtoFactory.NemesisCardSetId, IronManDeckDtoFactory.CreateNemesis());

		Create(SpidermanDeckDtoFactory.CardSetId, SpidermanDeckDtoFactory.Create());
		Create(SpidermanDeckDtoFactory.NemesisCardSetId, SpidermanDeckDtoFactory.CreateNemesis());

		Create(RhinoDeckDtoFactory.StandardIdentitySet, RhinoDeckDtoFactory.CreateStandard());
		Create(RhinoDeckDtoFactory.ExpertIdentitySet, RhinoDeckDtoFactory.CreateExpert());
		Create(RhinoDeckDtoFactory.SchemeCardSetId, RhinoDeckDtoFactory.CreateScheme());
		Create(RhinoDeckDtoFactory.CardSetId, RhinoDeckDtoFactory.CreateDeck());

		Create(KlawDeckDtoFactory.StandardIdentitySet, KlawDeckDtoFactory.CreateStandard());
		Create(KlawDeckDtoFactory.ExpertIdentitySet, KlawDeckDtoFactory.CreateExpert());
		Create(KlawDeckDtoFactory.SchemeCardSetId, KlawDeckDtoFactory.CreateScheme());
		Create(KlawDeckDtoFactory.CardSetId, KlawDeckDtoFactory.CreateDeck());

		Create(UltronDeckDtoFactory.StandardIdentitySet, UltronDeckDtoFactory.CreateStandard());
		Create(UltronDeckDtoFactory.ExpertIdentitySet, UltronDeckDtoFactory.CreateExpert());
		Create(UltronDeckDtoFactory.SchemeCardSetId, UltronDeckDtoFactory.CreateScheme());
		Create(UltronDeckDtoFactory.CardSetId, UltronDeckDtoFactory.CreateDeck());

		Create(BombScareDeckDtoFactory.CardSetId, BombScareDeckDtoFactory.Create());
		Create(TheMastersOfEvilDeckDtoFactory.CardSetId, TheMastersOfEvilDeckDtoFactory.Create());
		Create(UnderAttackDeckDtoFactory.CardSetId, UnderAttackDeckDtoFactory.Create());
		Create(LegionsOfHydraDeckDtoFactory.CardSetId, LegionsOfHydraDeckDtoFactory.Create());
		Create(TheDoomsdayChairDeckDtoFactory.CardSetId, TheDoomsdayChairDeckDtoFactory.Create());

		Create(StandardDeckDtoFactory.CardSetId, StandardDeckDtoFactory.Create());
		Create(ExpertDeckDtoFactory.CardSetId, ExpertDeckDtoFactory.Create());
	}
}