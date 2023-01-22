using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetAsidePlayerNemesisCompositeCommand : ICommand
{
	public void Execute()
	{
		CompositeCommandBuilder commands = new();
		ServiceLocator.Instance.Get<IPlayerService>()
			.Players
			.ForEach(player => commands.WithCommand(new SetAsidePlayerNemesisCommand(player)));
		commands.Build().Execute();
	}
}