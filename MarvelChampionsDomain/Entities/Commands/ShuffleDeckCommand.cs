using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class ShuffleDeckCommand : ICommand
{
	private readonly EntityId Owner;
	public ShuffleDeckCommand(EntityId owner)
	{
		ArgumentNullException.ThrowIfNull(owner);
		Owner = owner;
	}
	public void Execute() { }
}
