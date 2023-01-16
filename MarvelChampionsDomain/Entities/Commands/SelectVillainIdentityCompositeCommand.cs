using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectVillainIdentityCompositeCommand : ICommand
{
	public void Execute()
	{
		IPlayer player = ServiceLocator.Instance.Get<IVillainService>().Register(new Villain("Rhino"));
		new SelectVillainIdentityCommand(player).Execute();
	}
}