using MarvelChampionsApplication.CardSelections;
using MarvelChampionsApplication.ListCardSets;
using MarvelChampionsApplication.RegisterPlayer;

namespace MarvelChampionsApplication.CreateAndStartNewGame;

public sealed class CreateAndStartNewGameUseCaseInput
{
	public IUseCasePresenter<RegisterPlayerUseCaseInput>? RegisterPlayerPresenter { get; set; }
	public IUseCasePresenter<SelectAtLeastOneCardIO>? SelectAtLeastOneCardPresenter { get; set; }
	public IUseCasePresenter<SelectOneAndOnlyOneCardIO>? SelectOneAndOnlyOneCardPresenter { get; set; }
	public IUseCasePresenter<ListCardSetsUseCaseOutput>? SelectCardSetPresenter { get; set; }
}
