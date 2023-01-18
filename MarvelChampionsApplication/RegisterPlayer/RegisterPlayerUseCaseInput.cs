using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsApplication.RegisterPlayer;

public sealed class RegisterPlayerUseCaseInput
{
	public List<IHeroPlayer>? Players { get; set; }
	public string? Nickname { get; set; }
}
