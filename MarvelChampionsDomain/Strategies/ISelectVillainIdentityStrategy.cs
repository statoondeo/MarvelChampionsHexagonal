using MarvelChampionsDomain.Entities.Identities;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectVillainIdentityStrategy
{
	void SelectIdentity(List<IVillainIdentity> identities);
}
