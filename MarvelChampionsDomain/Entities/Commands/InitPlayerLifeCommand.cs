using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class InitPlayerLifeCommand : ICommand
{
	private readonly IPlayer Player;
	public InitPlayerLifeCommand(IPlayer player) => Player = player;
	public void Execute() => Player.InitLife();
}
