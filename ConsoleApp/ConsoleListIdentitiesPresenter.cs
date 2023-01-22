using MarvelChampionsApplication;
using MarvelChampionsApplication.ListHeroIdentities;
using MarvelChampionsApplication.ListVillainIdentities;

namespace ConsoleApp;

public sealed class ConsoleListIdentitiesPresenter : 
		IUseCasePresenter<ListHeroIdentitiesUseCaseOutput>, 
		IUseCasePresenter<SelectOneAndOnlyOneCardIO>
{
	public void Present(ListHeroIdentitiesUseCaseOutput output)
	{
		output.SelectedIdentity = output.Identities![new ConsoleSelectOnlyOneItem(
		  "Please pick an identity among following :",
		  output.Identities.Select(item => item.Title!).ToList()
		  ).DisplaySelectionScreen()];
	}
	public void Present(SelectOneAndOnlyOneCardIO output)
	{
		output.SelectedIdentity = output.Identities![new ConsoleSelectOnlyOneItem(
		  "Please pick an identity among following :",
		  output.Identities.Select(item => item.Title!).ToList()
		  ).DisplaySelectionScreen()].Id;
	}
}