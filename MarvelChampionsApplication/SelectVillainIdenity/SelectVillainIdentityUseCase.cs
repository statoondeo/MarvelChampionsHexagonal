using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsApplication.SelectVillainIdenity;

public sealed class SelectVillainIdentityUseCase : IUseCase
{
    private readonly SelectVillainIdentityUseCaseInput Input;
    public SelectVillainIdentityUseCase(SelectVillainIdentityUseCaseInput input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Input = input;
    }
    public void Execute() => ServiceLocator.Instance.Get<IVillainService>().Villain!.InitIdentity(Input.Identity!.Id);
}
