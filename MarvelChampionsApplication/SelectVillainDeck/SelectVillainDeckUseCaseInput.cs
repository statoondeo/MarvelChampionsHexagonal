using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.SelectVillainDeck;

public sealed class SelectVillainDeckUseCaseInput
{
	public ICardSet? Deck { get; set; }
}
