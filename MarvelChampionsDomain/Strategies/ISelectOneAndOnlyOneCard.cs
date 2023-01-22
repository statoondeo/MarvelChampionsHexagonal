using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectOneAndOnlyOneCard
{
	EntityId Select(List<CollectibleCardDto> identities);
}
