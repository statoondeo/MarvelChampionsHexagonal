using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class InitVillainsLifeCompositeCommand : ICommand
{
	public void Execute() => new InitPlayerLifeCommand(ServiceLocator.Instance.Get<IVillainService>().Villain!).Execute();
}
