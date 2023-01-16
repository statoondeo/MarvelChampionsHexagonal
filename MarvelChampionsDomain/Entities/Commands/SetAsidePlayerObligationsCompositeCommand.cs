using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetAsidePlayerObligationsCompositeCommand : ICommand
{
	public void Execute()
	{
		List<ICommand> commands = new();
		ServiceLocator.Instance.Get<IPlayerService>().Players.ToList().ForEach(player => commands.Add(new SetAsidePlayerObligationsCommand(player)));
		new CompositeCommand(commands).Execute();
	}
}