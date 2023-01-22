using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerMulliganCommand : ICommand
{
	private readonly IPlayer Player;
	public PlayerMulliganCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		ICardService cardService = ServiceLocator.Instance.Get<ICardService>();
		List<CollectibleCardDto> cardsToDiscard = ServiceLocator.Instance.Get<IGameService>()
			.SelectAtLeastOneCardStrategy
			.Select(cardService
				.GetCards(card => Player.Id.Equals(card.Owner) && LocationEnum.Hand.Equals(card.Location))
				.Select(card => new CollectibleCardDto()
				{
					Id = card.Id,
					Title = card.Title,
				})
				.ToList());
		CompositeCommandBuilder builder = new();
		cardsToDiscard
			.ForEach(card => builder.WithCommand(new DiscardCardCommand(cardService.GetCard(card.Id!))));
		builder.WithCommand(new DrawHandCommand(Player));
		builder.Build().Execute();
	}
}
