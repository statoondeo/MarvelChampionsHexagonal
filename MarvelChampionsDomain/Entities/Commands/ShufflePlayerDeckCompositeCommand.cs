using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class ShufflePlayerDeckCompositeCommand : ICommand
{
	public void Execute()
	{
		List<ICommand> commands = new();
		ServiceLocator.Instance.Get<IPlayerService>().Players.ToList().ForEach(player => commands.Add(new ShufflePlayerDeckCommand(player)));
		new CompositeCommand(commands).Execute();
	}
}
