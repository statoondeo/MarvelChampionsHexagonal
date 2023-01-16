using MarvelChampionsApplication;
using MarvelChampionsApplication.RegisterPlayer;

namespace ConsoleApp;

public sealed class ConsoleRegisterPlayerPresenter : IUseCasePresenter<RegisterPlayerUseCaseInput>
{
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
