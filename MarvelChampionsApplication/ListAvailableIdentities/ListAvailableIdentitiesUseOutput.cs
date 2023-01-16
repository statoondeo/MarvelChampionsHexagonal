using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsApplication.ListAvailableIdentities;

public sealed class ListAvailableIdentitiesUseCaseOutput
{
	public IPlayer? Player { get; set; }
	public List<IIdentity>? Identities { get; set; }
	public IIdentity? SelectedIdentity { get; set; }
}
