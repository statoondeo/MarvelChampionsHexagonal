using MarvelChampionsApplication;
using MarvelChampionsApplication.CardSelections;
using MarvelChampionsApplication.ListCardSets;
using MarvelChampionsApplication.RegisterPlayer;

using MarvelChampionsDomain.Entities.Sets;

namespace ConsoleApp;

public sealed class ConsolePresenter :
		IUseCasePresenter<RegisterPlayerUseCaseInput>,
		IUseCasePresenter<SelectAtLeastOneCardIO>,
		IUseCasePresenter<SelectOneAndOnlyOneCardIO>,
		IUseCasePresenter<ListCardSetsUseCaseOutput>
{
	public void Present(ListCardSetsUseCaseOutput output)
	{
		output.SelectedCardSet = output.CardSets![new ConsoleSelectOnlyOneItem(
		  "Please pick a card set among following :",
		  output.CardSets.Select(item => item.Description!).ToList()
		  ).DisplaySelectionScreen()];
	}
	public void Present(SelectOneAndOnlyOneCardIO output)
	{
		output.SelectedIdentity = output.Identities![new ConsoleSelectOnlyOneItem(
		  "Please pick an identity among following :",
		  output.Identities.Select(item => item.Title!).ToList()
		  ).DisplaySelectionScreen()];
	}
	public void Present(SelectAtLeastOneCardIO io)
	{
		bool[] selections = new bool[io.Identities!.Count];
		int selectedOption;
		ConsoleKeyInfo key;
		do
		{
			do
			{
				Console.Clear();
				Console.WriteLine("Please select cards among following :");
				Console.WriteLine();
				for (int i = 0; i < io.Identities!.Count; i++)
				{
					Console.Write($"\t {i + 1} : {io.Identities[i].Title}");
					if (selections[i]) Console.Write($"\t (Selected)");
					Console.WriteLine();
				}
				Console.WriteLine();
				Console.WriteLine("\t 0 : Finished");
				Console.WriteLine();
				Console.Write("\t Your choice : ");
				key = Console.ReadKey();
			} while (!int.TryParse(key.KeyChar.ToString(), out selectedOption) || (selectedOption < 0) || (selectedOption > io.Identities!.Count));
			if (selectedOption != 0) selections[selectedOption - 1] = !selections[selectedOption - 1];
		} while (selectedOption != 0);
		io.SelectedIdentities = new List<CollectibleCardDto>();
		for (int i = 0; i < selections.Length; i++)
		{
			if (!selections[i]) continue;
			io.SelectedIdentities.Add(io.Identities[i]);
		}
	}
	public void Present(RegisterPlayerUseCaseInput output)
	{
		Console.Clear();
		Console.Write("Registered players : ");
		output.Players?.ForEach(player =>
		{
			Console.Write($"{player.Nickname} ");
		});
		Console.WriteLine();
		Console.WriteLine();
		Console.Write("Enter player name : ");
		output.Nickname = Console.ReadLine();
	}
}