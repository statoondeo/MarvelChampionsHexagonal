using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetAsidePlayerNemesisCompositeCommand : ICommand
{
	public void Execute()
	{
		List<ICommand> commands = new();
		ServiceLocator.Instance.Get<IPlayerService>().Players.ToList().ForEach(player => commands.Add(new SetAsidePlayerNemesisCommand(player)));
		new CompositeCommand(commands).Execute();
	}
}