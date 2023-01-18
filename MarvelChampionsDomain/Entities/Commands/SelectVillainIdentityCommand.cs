using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectVillainIdentityCommand : ICommand
{
	public void Execute()
	{
		ServiceLocator.Instance.Get<IGameService>()
			.SelectVillainIdentityStrategy
			.SelectIdentity(
				ServiceLocator.Instance.Get<IVillainIdentityRepository>()
					.GetAll()
					.ToList());
		ServiceLocator.Instance.Get<IGameService>()
			.SelectVillainDeckStrategy
			.SelectVillainDeck(
				ServiceLocator.Instance.Get<ICardSetRepository>()
					.GetAll()
					.Where(cardSet => !cardSet.Identity && cardSet.Encounter)
					.ToList());
	}
}
