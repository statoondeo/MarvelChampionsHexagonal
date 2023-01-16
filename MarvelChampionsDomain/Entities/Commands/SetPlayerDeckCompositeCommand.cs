using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetPlayerDeckCompositeCommand : ICommand
{
	public void Execute()
	{
		List<ICommand> commands = new(4);
		ServiceLocator.Instance.Get<IPlayerService>().Players.ToList().ForEach(player => commands.Add(new SetPlayerDeckCommand(player)));
		new CompositeCommand(commands).Execute();
	}
}
