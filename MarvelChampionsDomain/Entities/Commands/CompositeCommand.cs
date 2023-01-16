namespace MarvelChampionsDomain.Entities.Commands;

public sealed class CompositeCommand : ICommand
{
	private readonly List<ICommand> Commands;
	public CompositeCommand(List<ICommand> commands) => Commands = commands;
	public void Execute() => Commands.ForEach(command => command.Execute());
}
