using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetAsidePlayerNemesisCommand : ICommand
{
	private readonly IPlayer Player;
	public SetAsidePlayerNemesisCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		List<ICard> cards = ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => card.Owner!.Equals(Player) && card.Classification.Equals(ClassificationEnum.Nemesis)).ToList();
		cards.ForEach(card => card.SetLocation(LocationEnum.Exil));
	}
}
