namespace MarvelChampionsDomain.Entities.Sets;

public interface ICardSet : IEntity
{
	bool Identity { get; }
	string Description { get; }
	List<CollectibleCardDto> Cards { get; }
	void Append(CollectibleCardDto card);
	void Append(ICardSet cardSet);
}
