using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Games;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsDomain.Entities.Builders;

public sealed class GameBuilder
{
	private ICommand? SetupCommand;
	private readonly IRegisterPlayerStrategy RegisterPlayerStrategy;
	private readonly ISelectPlayerIdentityStrategy SelectPlayerIdentityStrategy;
	private readonly ISelectVillainIdentityStrategy SelectVillainIdentityStrategy;
	private readonly ISelectPlayerDeckStrategy SelectPlayerDeckStrategy;
	private readonly ISelectVillainDeckStrategy SelectVillainDeckStrategy;
	private readonly IChooseCardStrategy SelectCardStrategy;

	public GameBuilder(
		IRegisterPlayerStrategy registerPlayerStrategy,
		ISelectPlayerIdentityStrategy selectPlayerIdentityStrategy,
		ISelectVillainIdentityStrategy selectVillainIdentityStrategy,
		ISelectPlayerDeckStrategy selectPlayerDeckStrategy,
		ISelectVillainDeckStrategy selectVillainDeckStrategy,
		IChooseCardStrategy selectCardStrategy)
	{
		ArgumentNullException.ThrowIfNull(registerPlayerStrategy);
		ArgumentNullException.ThrowIfNull(selectPlayerIdentityStrategy);
		ArgumentNullException.ThrowIfNull(selectVillainIdentityStrategy);
		ArgumentNullException.ThrowIfNull(selectPlayerDeckStrategy);
		ArgumentNullException.ThrowIfNull(selectVillainDeckStrategy);
		ArgumentNullException.ThrowIfNull(selectCardStrategy);

		RegisterPlayerStrategy = registerPlayerStrategy;
		SelectPlayerIdentityStrategy = selectPlayerIdentityStrategy;
		SelectVillainIdentityStrategy = selectVillainIdentityStrategy;
		SelectPlayerDeckStrategy = selectPlayerDeckStrategy;
		SelectVillainDeckStrategy = selectVillainDeckStrategy;
		SelectCardStrategy = selectCardStrategy;
	}
	public GameBuilder WithSetupCommand(ICommand setupCommand)
	{
		SetupCommand = setupCommand ?? throw new ArgumentNullException(nameof(setupCommand));
		return this;
	}
	public Game Build() => new(SetupCommand!, 
									RegisterPlayerStrategy, 
									SelectPlayerIdentityStrategy, 
									SelectPlayerDeckStrategy,
									SelectVillainIdentityStrategy,
									SelectVillainDeckStrategy,
									SelectCardStrategy);
}
