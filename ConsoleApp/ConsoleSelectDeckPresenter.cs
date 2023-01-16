using MarvelChampionsApplication;
using MarvelChampionsApplication.ListAvailableDecks;

namespace ConsoleApp;

public sealed class ConsoleSelectDeckPresenter : IUseCasePresenter<ListDecksUseCaseOutput>
{
	public void Present(ListDecksUseCaseOutput output)
	{
		output.SelectedDeck = output.Decks![new ConsoleSelectOnlyOneItem(
		  "Please pick a deck among following :",
		  output.Decks.Select(item => item.Description!).ToList()
		  ).DisplaySelectionScreen()];
	}
}
