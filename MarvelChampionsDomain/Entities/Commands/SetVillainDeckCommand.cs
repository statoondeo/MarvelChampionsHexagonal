using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetVillainDeckCommand : ICommand
{
	private readonly IPlayer Player;
	public SetVillainDeckCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		List<ICard> cards = ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => card.Owner!.Equals(Player) && card.Location.Equals(LocationEnum.None)).ToList();
		cards.ForEach(card => card.SetLocation(LocationEnum.Deck));
	}
}
