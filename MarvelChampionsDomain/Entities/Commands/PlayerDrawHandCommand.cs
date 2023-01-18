using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerDrawHandCommand : ICommand
{
	private readonly IPlayer Player;
	public PlayerDrawHandCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		//int handContentSize = ServiceLocator.Instance.Get<ICardService>()
		//	.GetCards(card => card.Owner!.Equals(Player) && card.Location.Equals(LocationEnum.Hand)).Count;
		//new CompositeCommand(Enumerable.Repeat(new PlayerDrawCardCommand(Player), Player.Identity!.HandSize - handContentSize).ToList<ICommand>())
		//	.Execute();
	}
}
