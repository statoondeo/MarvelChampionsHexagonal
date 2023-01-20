using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class ShuffleVillainDeckCompositeCommand : ICommand
{
	public void Execute() => new ShuffleDeckCommand(ServiceLocator.Instance.Get<IVillainService>().Villain!.Id).Execute();
}