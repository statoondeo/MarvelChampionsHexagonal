using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Basics;
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
	public ISelectPlayerIdentityStrategy SelectPlayerIdentityStrategy { get; }
	public ISelectVillainIdentityStrategy SelectVillainIdentityStrategy { get; }
	public ISelectPlayerDeckStrategy SelectPlayerDeckStrategy { get; }
	public ISelectVillainDeckStrategy SelectVillainDeckStrategy { get; }
	public IChooseCardStrategy SelectCardStrategy { get; }

	public Game(
		ICommand setupCommand,
		IRegisterPlayerStrategy registerPlayerStrategy,
		ISelectPlayerIdentityStrategy selectPlayerIdentityStrategy,
		ISelectPlayerDeckStrategy selectPlayerDeckStrategy,
		ISelectVillainIdentityStrategy selectVillainIdentityStrategy,
		ISelectVillainDeckStrategy selectVillainDeckStrategy,
		IChooseCardStrategy selectCardStrategy) 
		: base(EntityId.Create())
	{
		ArgumentNullException.ThrowIfNull(setupCommand);
		ArgumentNullException.ThrowIfNull(registerPlayerStrategy);
		ArgumentNullException.ThrowIfNull(selectPlayerIdentityStrategy);
		ArgumentNullException.ThrowIfNull(selectPlayerDeckStrategy);
		ArgumentNullException.ThrowIfNull(selectVillainDeckStrategy);
		ArgumentNullException.ThrowIfNull(selectVillainIdentityStrategy);
		ArgumentNullException.ThrowIfNull(selectCardStrategy);

		SetupCommand = setupCommand;
		RegisterPlayerStrategy = registerPlayerStrategy;
		SelectPlayerIdentityStrategy = selectPlayerIdentityStrategy;
		SelectPlayerDeckStrategy = selectPlayerDeckStrategy;
		SelectVillainDeckStrategy = selectVillainDeckStrategy;
		SelectVillainIdentityStrategy = selectVillainIdentityStrategy;
		SelectCardStrategy = selectCardStrategy;
	}

	public void Start()
	{
		RegisterPlayerStrategy.RegisterPlayer();
		Logger.Log("Game.Start");
		SetupCommand.Execute();
	}
}
