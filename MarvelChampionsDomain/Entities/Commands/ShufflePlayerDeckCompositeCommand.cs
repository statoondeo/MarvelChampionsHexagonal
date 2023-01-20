using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class ShufflePlayerDeckCompositeCommand : ICommand
{
	public void Execute()
	{
		CompositeCommandBuilder command = new();
		ServiceLocator.Instance.Get<IPlayerService>().Players.ToList()
			.ForEach(player => command.WithCommand(new ShuffleDeckCommand(player.Id)));
		command.Build().Execute();
	}
}
