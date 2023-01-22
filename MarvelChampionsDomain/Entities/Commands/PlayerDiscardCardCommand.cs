using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Enums;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class DiscardCardCommand : ICommand
{
	private readonly ICard Card;
	public DiscardCardCommand(ICard card) => Card = card;
	public void Execute() => Card.SetLocation(LocationEnum.Discard);
}
