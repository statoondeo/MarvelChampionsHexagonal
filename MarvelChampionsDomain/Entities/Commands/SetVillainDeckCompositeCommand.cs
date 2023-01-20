using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetVillainDeckCompositeCommand : ICommand
{
	public void Execute()
	{
		new CompositeCommand(new(2) {
			new SetVillainDeckCommand(),
			new ShuffleDeckCommand(ServiceLocator.Instance.Get<IVillainService>().Villain!.Id)
		}).Execute();
	}
}