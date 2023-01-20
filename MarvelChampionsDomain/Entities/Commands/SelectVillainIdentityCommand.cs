using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectVillainIdentityCommand : ICommand
{
	public void Execute()
	{
		ServiceLocator.Instance.Get<IGameService>()
			.SelectVillainIdentityStrategy
			.SelectIdentity(
				ServiceLocator.Instance.Get<IVillainIdentityRepository>()
					.GetAll()
					.ToList());
	}
}
