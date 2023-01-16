using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsDomain.Entities.Services;

public interface IGameService : IService
{
	IRegisterPlayerStrategy RegisterPlayerStrategy { get; }
	ISelectPlayerIdentityStrategy SelectPlayerIdentityStrategy { get; }
	ISelectPlayerDeckStrategy SelectDeckStrategy { get; }
	IChooseCardStrategy SelectCardStrategy { get; }
	void Start();
}
