using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerDrawCardCommand : ICommand
{
	private readonly IPlayer Player;
	public PlayerDrawCardCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => card.Owner!.Equals(Player.Id) && card.Location.Equals(LocationEnum.Deck))[0]
			.SetLocation(LocationEnum.Hand);
	}
}
