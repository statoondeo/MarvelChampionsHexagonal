namespace MarvelChampionsApplication.SelectPlayerIdentity;

public sealed class SelectPlayerIdentityUseCase : IUseCase
{
	private readonly SelectPlayerIdentityUseCaseInput Input;
	public SelectPlayerIdentityUseCase(SelectPlayerIdentityUseCaseInput input)
	{
		ArgumentNullException.ThrowIfNull(input);
		Input = input;
	}
	public void Execute() => Input.Player!.InitIdentity(Input.Identity!.Id);
}
