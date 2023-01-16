namespace MarvelChampionsDomain.Entities.Commands;

public sealed class NullCommand : ICommand
{
	public void Execute() { /* NullObject */ }
}