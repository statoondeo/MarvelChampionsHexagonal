using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsApplication.RegisterPlayer;

public sealed class RegisterPlayerUseCase : IUseCase
{
	private readonly RegisterPlayerUseCaseInput Input;
	public RegisterPlayerUseCase(RegisterPlayerUseCaseInput input)
	{
		ArgumentNullException.ThrowIfNull(input);
		Input = input;
	}
	public void Execute() => ServiceLocator.Instance.Get<IPlayerService>().Register(new Player(Input.Nickname!));
}
