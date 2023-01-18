using MarvelChampionsDomain.Entities.Identities;

namespace MarvelChampionsApplication.ListVillainIdentities;

public sealed class ListVillainIdentitiesUseCaseOutput
{
    public List<IVillainIdentity>? Identities { get; set; }
    public IVillainIdentity? SelectedIdentity { get; set; }
}
