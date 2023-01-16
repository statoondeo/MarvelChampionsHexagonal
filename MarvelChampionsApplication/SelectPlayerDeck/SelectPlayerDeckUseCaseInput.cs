using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.SelectPlayerDeck;

public sealed class SelectPlayerDeckUseCaseInput
{
	public IPlayer? Player { get; set; }
	public ICardSet? Deck { get; set; }
}
