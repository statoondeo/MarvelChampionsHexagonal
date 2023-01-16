using MarvelChampionsDomain.Entities.Commands;

namespace MarvelChampionsDomain.Entities.Builders;

public sealed class CompositeCommandBuilder
{
    private readonly List<ICommand> Commands;
    public CompositeCommandBuilder() => Commands = new List<ICommand>();
    public CompositeCommandBuilder WithCommand(ICommand command)
    {
        Commands.Add(command);
        return this;
    }
    public ICommand Build() => new CompositeCommand(Commands);
}
