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
	public ISelectCardSetStrategy SelectCardSetStrategy { get; }
	public IChooseCardStrategy SelectCardStrategy { get; }

	public Game(
		ICommand setupCommand,
		IRegisterPlayerStrategy registerPlayerStrategy,
		ISelectCardSetStrategy selectPlayerDeckStrategy,
		ISelectOneAndOnlyOneCard selectVillainIdentityStrategy,
		IChooseCardStrategy selectCardStrategy) 
		: base(EntityId.Create())
	{
		ArgumentNullException.ThrowIfNull(setupCommand);
		ArgumentNullException.ThrowIfNull(registerPlayerStrategy);
		ArgumentNullException.ThrowIfNull(selectPlayerDeckStrategy);
		ArgumentNullException.ThrowIfNull(selectVillainIdentityStrategy);
		ArgumentNullException.ThrowIfNull(selectCardStrategy);

		SetupCommand = setupCommand;
		RegisterPlayerStrategy = registerPlayerStrategy;
		SelectCardSetStrategy = selectPlayerDeckStrategy;
		SelectOneAndOnlyOneCard = selectVillainIdentityStrategy;
		SelectCardStrategy = selectCardStrategy;
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
