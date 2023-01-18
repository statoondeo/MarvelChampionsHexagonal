namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SelectVillainIdentityCompositeCommand : ICommand
{
	public void Execute() => new SelectVillainIdentityCommand().Execute();
}