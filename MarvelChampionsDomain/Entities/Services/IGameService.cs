using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsDomain.Entities.Services;

public interface IGameService : IService
{
	IRegisterPlayerStrategy RegisterPlayerStrategy { get; }
	ISelectOneAndOnlyOneCard SelectOneAndOnlyOneCard { get; }
	ISelectCardSetStrategy SelectCardSetStrategy { get; }
	ISelectAtLeastOneCardStrategy SelectAtLeastOneCardStrategy { get; }
	void Start();
}
