using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Enums;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerDiscardCardCommand : ICommand
{
	private readonly ICard Card;
	public PlayerDiscardCardCommand(ICard card) => Card = card;
	public void Execute() => Card.SetLocation(LocationEnum.Discard);
}
