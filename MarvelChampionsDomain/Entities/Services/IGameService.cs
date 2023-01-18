using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsDomain.Entities.Services;

public interface IGameService : IService
{
	IRegisterPlayerStrategy RegisterPlayerStrategy { get; }
	ISelectPlayerIdentityStrategy SelectPlayerIdentityStrategy { get; }
	ISelectVillainIdentityStrategy SelectVillainIdentityStrategy { get; }
	ISelectPlayerDeckStrategy SelectPlayerDeckStrategy { get; }
	ISelectVillainDeckStrategy SelectVillainDeckStrategy { get; }
	IChooseCardStrategy SelectCardStrategy { get; }
	void Start();
}
