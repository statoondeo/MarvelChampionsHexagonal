using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsApplication.ListAvailableIdentities;

public sealed class ListAvailableIdentitiesUseCase : IUseCase
{
	private readonly IUseCasePresenter<ListAvailableIdentitiesUseCaseOutput> Presenter;
	public ListAvailableIdentitiesUseCaseOutput? Output { get; private set; }
	public ListAvailableIdentitiesUseCase(IUseCasePresenter<ListAvailableIdentitiesUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public void Execute()
	{
		List<IIdentity> identities = ServiceLocator.Instance.Get<IIdentityRepository>().GetAll();
		ServiceLocator.Instance.Get<IPlayerService>().Players
			.Where(item => item is not null)
			.ToList()
			.ForEach(player =>
		{
			identities.Remove(player.Identity!);
		});
		Output = new ListAvailableIdentitiesUseCaseOutput() { Identities = identities };
		Presenter.Present(Output);
	}
}
