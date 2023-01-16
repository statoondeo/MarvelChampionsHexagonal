using MarvelChampionsApplication.ListAvailableIdentities;
using MarvelChampionsApplication;

namespace ConsoleApp;

public sealed class ConsoleListIdentitiesPresenter : IUseCasePresenter<ListAvailableIdentitiesUseCaseOutput>
{
	public void Present(ListAvailableIdentitiesUseCaseOutput output)
	{
		output.SelectedIdentity = output.Identities![new ConsoleSelectOnlyOneItem(
		  "Please pick an identity among following :",
		  output.Identities.Select(item => item.Title!).ToList()
		  ).DisplaySelectionScreen()];
	}
}