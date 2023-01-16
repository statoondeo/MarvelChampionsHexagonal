using MarvelChampionsDomain.Entities.Cards;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class ResolveCardSetupCommand : ICommand
{
	private readonly ICard Card;
	public ResolveCardSetupCommand(ICard card) => Card = card;
	public void Execute() => Card.SetupCommand.Execute();
}
