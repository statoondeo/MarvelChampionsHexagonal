using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.ListAvailableDecks;

public sealed class ListDecksUseCaseOutput
{
    public List<ICardSet>? Decks { get; set; }
    public ICardSet? SelectedDeck { get; set; }
}
