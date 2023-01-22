using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class InitPlayersLifeCompositeCommand : ICommand
{
	public void Execute()
	{
		CompositeCommandBuilder commands = new();
		ServiceLocator.Instance.Get<IPlayerService>()
			.Players
			.ForEach(player => commands.WithCommand(new InitPlayerLifeCommand(player)));
		commands.Build().Execute();
	}
}
