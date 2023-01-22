using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectAtLeastOneCardStrategy
{
	List<CollectibleCardDto> Select(List<CollectibleCardDto> identities);
}
