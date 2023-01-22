using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectOneAndOnlyOneCard
{
	CollectibleCardDto Select(List<CollectibleCardDto> identities);
}
