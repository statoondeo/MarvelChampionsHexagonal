using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsDomain.Entities.Services;

public interface IGameService : IService
{
	IRegisterPlayerStrategy RegisterPlayerStrategy { get; }
	ISelectOneAndOnlyOneCard SelectOneAndOnlyOneCard { get; }
	ISelectCardSetStrategy SelectCardSetStrategy { get; }
	IChooseCardStrategy SelectCardStrategy { get; }
	void Start();
}
