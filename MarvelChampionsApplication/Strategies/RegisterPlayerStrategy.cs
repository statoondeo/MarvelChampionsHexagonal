using MarvelChampionsApplication.RegisterPlayer;

using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsApplication.Strategies;

public sealed class RegisterPlayerStrategy : IRegisterPlayerStrategy
{
	private readonly IUseCasePresenter<RegisterPlayerUseCaseInput> Presenter;
	public RegisterPlayerStrategy(IUseCasePresenter<RegisterPlayerUseCaseInput> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public void RegisterPlayer()
	{
		RegisterPlayerUseCaseInput output = new();
		Presenter.Present(output);
		while(!string.IsNullOrWhiteSpace(output.Nickname)) 
		{
			// On associe l'identité sélectionnée au joueur
			new RegisterPlayerUseCase(new RegisterPlayerUseCaseInput()
			{
				Nickname = output.Nickname,
			}).Execute(); 
			output = new RegisterPlayerUseCaseInput();
			output.Players = ServiceLocator.Instance.Get<IPlayerService>().Players.ToList();
			Presenter.Present(output);
		}
	}
}
