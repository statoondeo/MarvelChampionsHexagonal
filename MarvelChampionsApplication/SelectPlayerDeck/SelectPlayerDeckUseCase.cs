namespace MarvelChampionsApplication.SelectPlayerDeck;

public sealed class SelectPlayerDeckUseCase : IUseCase
{
	private readonly SelectPlayerDeckUseCaseInput Input;
	public SelectPlayerDeckUseCase(SelectPlayerDeckUseCaseInput input)
	{
		ArgumentNullException.ThrowIfNull(input);
		Input = input;
	}
	public void Execute() => Input.Player!.SetDeckCardSetId(Input.Deck!.Id);
}
