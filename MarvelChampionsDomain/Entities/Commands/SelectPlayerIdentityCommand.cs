using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectPlayerIdentityCommand : ICommand
{
	private readonly IPlayer Player;
	public SelectPlayerIdentityCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		ServiceLocator.Instance.Get<IGameService>().SelectPlayerIdentityStrategy.SelectIdentityForPlayer(Player);
		ServiceLocator.Instance.Get<IGameService>().SelectDeckStrategy.SelectDeckForPlayer(Player);
	}
}
