using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectRandomFirstPlayerCommand : ICommand
{
	public void Execute()
	{
		IPlayerService playerService = ServiceLocator.Instance.Get<IPlayerService>();
		playerService.SetFirst(Random.Shared.Next(playerService.Players.Count));
	}
}