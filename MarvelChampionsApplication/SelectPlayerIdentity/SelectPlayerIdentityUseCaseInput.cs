using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsApplication.SelectPlayerIdentity;

public sealed class SelectPlayerIdentityUseCaseInput
{
	public IPlayer? Player { get; set; }
	public IIdentity? Identity { get; set; }
}
