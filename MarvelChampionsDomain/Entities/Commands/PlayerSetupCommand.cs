using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerSetupCommand : ICommand
{
	private readonly IPlayer Player;
	public PlayerSetupCommand(IPlayer player) => Player = player;
	public void Execute() => Player.Identity!.Card!.SetupCommand.Execute();
}
