using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.ListCardSets;

public sealed class ListCardSetsUseCaseOutput
{
	public List<ICardSet>? CardSets { get; set; }
	public ICardSet? SelectedCardSet { get; set; }
}
