using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetVillainDeckCompositeCommand : ICommand
{
	public void Execute()
	{
		IPlayer villain = ServiceLocator.Instance.Get<IVillainService>().Villain!;
		new CompositeCommand(new(2) {
			new SetVillainDeckCommand(villain),
			new ShufflePlayerDeckCommand(villain)
		}).Execute();
	}
}