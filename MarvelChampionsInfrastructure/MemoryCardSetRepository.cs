using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

using MarvelChampionsInfrastructure.Data;

namespace MarvelChampionsInfrastructure;

public sealed class MemoryCardSetRepository : BaseRepository<EntityId, ICardSet>, ICardSetRepository
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
		Create(MissHulkDeckDtoFactory.CardSetId, MissHulkDeckDtoFactory.Create());
		Create(BlackPantherDeckDtoFactory.CardSetId, BlackPantherDeckDtoFactory.Create());
		Create(IronManDeckDtoFactory.CardSetId, IronManDeckDtoFactory.Create());
		Create(SpidermanDeckDtoFactory.CardSetId, SpidermanDeckDtoFactory.Create());
	}
}