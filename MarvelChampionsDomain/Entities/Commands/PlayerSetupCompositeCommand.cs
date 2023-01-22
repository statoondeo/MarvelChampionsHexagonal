using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerSetupCompositeCommand : ICommand
{
	public void Execute()
	{
		CompositeCommandBuilder builder = new();
		ServiceLocator.Instance.Get<IPlayerService>()
			.Players
			.ForEach(player => builder.WithCommand(new PlayerSetupCommand(player)));
		builder.Build().Execute();
	}
}