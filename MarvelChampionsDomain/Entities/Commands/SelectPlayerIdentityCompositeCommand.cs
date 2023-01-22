using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectPlayerIdentityCompositeCommand : ICommand
{
	public void Execute()
	{
		CompositeCommandBuilder builder = new();
		ServiceLocator.Instance.Get<IPlayerService>()
			.Players
			.ForEach(player => builder.WithCommand(new SelectPlayerIdentityCommand(player)));
		builder.Build().Execute();
	}
}
