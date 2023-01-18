using MarvelChampionsDomain.Entities.Identities;

namespace MarvelChampionsApplication.SelectVillainIdenity;

public sealed class SelectVillainIdentityUseCaseInput
{
    public IVillainIdentity? Identity { get; set; }
}
