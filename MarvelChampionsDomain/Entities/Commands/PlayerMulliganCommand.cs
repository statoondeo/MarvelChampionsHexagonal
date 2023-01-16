using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerMulliganCommand : ICommand
{
	private readonly IPlayer Player;
	private readonly IChooseCardStrategy ChooseCardStrategy;
	public PlayerMulliganCommand(IPlayer player, IChooseCardStrategy chooseCardStrategy)
	{
		Player = player;
		ChooseCardStrategy = chooseCardStrategy;
	}
	public void Execute()
	{
		bool AmongFilter(ICard card) => card.Owner!.Equals(Player) && card.Location.Equals(LocationEnum.Hand);

		List<ICard> cardsToDiscard = ChooseCardStrategy.ChooseCards(AmongFilter).ToList();
		List<ICommand> commands = new();
		cardsToDiscard.ForEach(card => commands.Add(new PlayerDiscardCardCommand(card)));
		commands.Add(new PlayerDrawHandCommand(Player));
		new CompositeCommand(commands).Execute();
	}
}
