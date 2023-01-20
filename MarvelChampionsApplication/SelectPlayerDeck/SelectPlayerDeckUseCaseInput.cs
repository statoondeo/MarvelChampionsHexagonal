using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.SelectPlayerDeck;

public sealed class SelectPlayerDeckUseCaseInput
{
	public IHeroPlayer? Player { get; set; }
	public ICardSet? Deck { get; set; }
}
