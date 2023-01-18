using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsApplication.ListHeroIdentities;

public sealed class ListHeroIdentitiesUseCaseOutput
{
	public IHeroPlayer? Player { get; set; }
	public List<IHeroIdentity>? Identities { get; set; }
	public IHeroIdentity? SelectedIdentity { get; set; }
}
