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
		ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => card.Owner!.Equals(Player.Id) && card.Classification.Equals(ClassificationEnum.Nemesis))
			.ForEach(card => card.SetLocation(LocationEnum.Exil));
	}
}
