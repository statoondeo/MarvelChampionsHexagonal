using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsApplication.SelectPlayerIdentity;

public sealed class SelectPlayerIdentityUseCaseInput
{
	public IHeroPlayer? Player { get; set; }
	public IHeroIdentity? Identity { get; set; }
}
