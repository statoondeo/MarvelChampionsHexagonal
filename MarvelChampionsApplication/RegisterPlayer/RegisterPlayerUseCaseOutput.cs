using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsApplication.RegisterPlayer;

public sealed class RegisterPlayerUseCaseOutput
{
	public IPlayer? Player { get; set; }
}
