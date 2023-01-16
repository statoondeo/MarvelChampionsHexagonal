using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerDrawHandCompositeCommand : ICommand
{
	public void Execute()
	{
		CompositeCommandBuilder builder = new();
		ServiceLocator.Instance.Get<IPlayerService>().Players.ToList().ForEach(player => builder.WithCommand(new PlayerDrawHandCommand(player)));
		builder.Build().Execute();
	}
}
