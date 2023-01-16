using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsApplication.ListAvailableDecks;

public sealed class ListDecksUseCase : IUseCase
{
    private readonly IUseCasePresenter<ListDecksUseCaseOutput> Presenter;
    public ListDecksUseCaseOutput? Output { get; private set; }
    public ListDecksUseCase(IUseCasePresenter<ListDecksUseCaseOutput> presenter)
    {
        ArgumentNullException.ThrowIfNull(presenter);
        Presenter = presenter;
    }
    public void Execute()
    {
		Output = new ListDecksUseCaseOutput () 
        { 
            Decks = ServiceLocator.Instance.Get<ICardSetRepository>().GetAll().Where(deck => !deck.Identity).ToList()
        };
        Presenter.Present(Output);
    }
}
