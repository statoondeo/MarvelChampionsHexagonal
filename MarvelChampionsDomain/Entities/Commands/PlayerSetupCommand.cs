using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class PlayerSetupCommand : ICommand
{
	private readonly IHeroPlayer Player;
	public PlayerSetupCommand(IHeroPlayer player) => Player = player;
	public void Execute() 
		=> ServiceLocator.Instance.Get<ICardService>()
			.GetCard(
				ServiceLocator.Instance.Get<IHeroIdentityRepository>()
				.GetById(Player.Identity!)
				.Card)
			.SetupCommand
			.Execute();
}
