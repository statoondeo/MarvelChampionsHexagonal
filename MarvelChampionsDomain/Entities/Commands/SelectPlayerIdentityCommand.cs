using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectPlayerIdentityCommand : ICommand
{
	private readonly IHeroPlayer Player;
	public SelectPlayerIdentityCommand(IHeroPlayer player) => Player = player;
	public void Execute()
	{
		ISet<EntityId> usedHeroes = ServiceLocator.Instance.Get<IPlayerService>()
			.Players
			.Where(player => player.Identity is not null)
			.Select(player => player.Identity!)
			.ToHashSet();
		ServiceLocator.Instance.Get<IGameService>()
			.SelectPlayerIdentityStrategy
			.SelectIdentityForPlayer(
				Player,
				ServiceLocator.Instance.Get<IHeroIdentityRepository>()
					.GetAll()
					.Where(hero => !usedHeroes.Contains(hero.Id))
					.Select(hero => hero)
					.ToList());
		ServiceLocator.Instance.Get<IGameService>()
			.SelectPlayerDeckStrategy
			.SelectDeckForPlayer(
				Player, 
				ServiceLocator.Instance.Get<ICardSetRepository>()
					.GetAll()
					.Where(cardSet => !cardSet.Identity && !cardSet.Encounter && !cardSet.Standard)
					.ToList());
	}
}
