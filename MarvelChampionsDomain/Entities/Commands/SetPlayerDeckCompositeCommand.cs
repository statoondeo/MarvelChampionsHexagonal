using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetPlayerDeckCompositeCommand : ICommand
{
	public void Execute()
	{
		CompositeCommandBuilder commands = new();
		ServiceLocator.Instance.Get<IPlayerService>()
			.Players
			.ForEach(player => 
			{
				commands.WithCommand(new SetPlayerDeckCommand(player));
				commands.WithCommand(new RenumCardsCommand(player.Id));
				commands.WithCommand(new ShuffleDeckCommand(player.Id));
			});
		commands.Build().Execute();
	}
}
