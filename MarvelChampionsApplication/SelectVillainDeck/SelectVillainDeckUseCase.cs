using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsApplication.SelectVillainDeck;

public sealed class SelectVillainDeckUseCase : IUseCase
{
    private readonly SelectVillainDeckUseCaseInput Input;
    public SelectVillainDeckUseCase(SelectVillainDeckUseCaseInput input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Input = input;
    }
	public void Execute() => ServiceLocator.Instance.Get<IVillainService>().Villain!.SetModulatCardSetId(Input.Deck!.Id);
}
