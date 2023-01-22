using MarvelChampionsApplication;
using MarvelChampionsApplication.ListCardSets;

namespace ConsoleApp;

public sealed class ConsoleSelectDeckPresenter : IUseCasePresenter<ListCardSetsUseCaseOutput>
{
	public void Present(ListCardSetsUseCaseOutput output)
	{
		output.SelectedCardSet = output.CardSets![new ConsoleSelectOnlyOneItem(
		  "Please pick a deck among following :",
		  output.CardSets.Select(item => item.Description!).ToList()
		  ).DisplaySelectionScreen()];
	}
}
