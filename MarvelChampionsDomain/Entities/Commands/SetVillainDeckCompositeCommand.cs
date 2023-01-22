using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetVillainDeckCompositeCommand : ICommand
{
	public void Execute()
	{
		new CompositeCommandBuilder()
			.WithCommand(new SetVillainDeckCommand())
			.WithCommand(new RenumCardsCommand(ServiceLocator.Instance.Get<IVillainService>().Villain!.Id))
			.WithCommand(new ShuffleDeckCommand(ServiceLocator.Instance.Get<IVillainService>().Villain!.Id))
			.Build()
			.Execute();
	}
}