using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class DrawHandCommand : ICommand
{
	private readonly IPlayer Player;
	public DrawHandCommand(IPlayer player) => Player = player;
	public void Execute()
	{
		IHeroIdentity identity = ServiceLocator.Instance.Get<IHeroIdentityRepository>().GetById(Player.Identity!);
		int handContentSize = ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => card.Owner!.Equals(Player.Id) && card.Location.Equals(LocationEnum.Hand)).Count;
		new CompositeCommand(Enumerable.Repeat(new PlayerDrawCardCommand(Player), identity.HandSize - handContentSize).ToList<ICommand>())
			.Execute();
	}
}
