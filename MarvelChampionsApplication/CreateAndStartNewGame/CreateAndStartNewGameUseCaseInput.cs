using MarvelChampionsApplication.ListAvailableDecks;
using MarvelChampionsApplication.ListAvailableIdentities;
using MarvelChampionsApplication.RegisterPlayer;

using MarvelChampionsDomain.Entities;

namespace MarvelChampionsApplication.CreateAndStartNewGame;

public sealed class CreateAndStartNewGameUseCaseInput
{
	public IUseCasePresenter<RegisterPlayerUseCaseInput>? RegisterPlayerPresenter { get; set; }
	public IUseCasePresenter<ListAvailableIdentitiesUseCaseOutput>? SelectPlayerIdentityPresenter { get; set; }
	public IUseCasePresenter<ListDecksUseCaseOutput>? SelectDeckPresenter { get; set; }
    public IChooseCardStrategy? SelectCardStrategy { get; set; }
}
