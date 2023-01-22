using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsDomain.Entities.Cards;

public static class ICardExtensions
{
	public static CollectibleCardDto ToCollectibleCardDto(this ICard card) => new()
		{
			Id = card.Id,
			Classification = card.Classification,
			Type = card.Type,
			Title = card.Title,
			CardSet = card.CardSet
		};
}