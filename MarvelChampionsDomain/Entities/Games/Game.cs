using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Strategies;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Games;

public sealed class Game : BaseEntity, IGameService
{
	private readonly ICommand SetupCommand;
	public IRegisterPlayerStrategy RegisterPlayerStrategy { get; }
	public ISelectOneAndOnlyOneCard SelectOneAndOnlyOneCard { get; }
	public ISelectAtLeastOneCardStrategy SelectAtLeastOneCardStrategy { get; }
	public ISelectCardSetStrategy SelectCardSetStrategy { get; }

	public Game(
		ICommand setupCommand,
		IRegisterPlayerStrategy registerPlayerStrategy,
		ISelectOneAndOnlyOneCard selectOneAndOnlyOneCardStrategy,
		ISelectAtLeastOneCardStrategy selectAtLeastOneCardStrategy,
		ISelectCardSetStrategy selectCardSetStrategy) 
		: base(EntityId.Create())
	{
		ArgumentNullException.ThrowIfNull(setupCommand);
		ArgumentNullException.ThrowIfNull(registerPlayerStrategy);
		ArgumentNullException.ThrowIfNull(selectOneAndOnlyOneCardStrategy);
		ArgumentNullException.ThrowIfNull(selectAtLeastOneCardStrategy);
		ArgumentNullException.ThrowIfNull(selectCardSetStrategy);

		SetupCommand = setupCommand;
		RegisterPlayerStrategy = registerPlayerStrategy;
		SelectOneAndOnlyOneCard = selectOneAndOnlyOneCardStrategy;
		SelectAtLeastOneCardStrategy = selectAtLeastOneCardStrategy;
		SelectCardSetStrategy = selectCardSetStrategy;
	}
	public void Start()
	{
		RegisterPlayerStrategy.RegisterPlayer();
		Logger.Log("Game.Start");
		SetupCommand.Execute();
		Logger.Log("Setup completed");
		ServiceLocator.Instance.Get<ICardService>()
			.GetCards(card => true)
			.ForEach(card => Logger.Log(card.ToString()));

	}
}
