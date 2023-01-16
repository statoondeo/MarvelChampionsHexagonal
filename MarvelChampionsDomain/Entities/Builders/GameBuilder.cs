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
	private readonly ISelectPlayerDeckStrategy SelectDeckStrategy;
	private readonly IChooseCardStrategy SelectCardStrategy;

	public GameBuilder(
		IRegisterPlayerStrategy registerPlayerStrategy,
		ISelectPlayerIdentityStrategy selectPlayerIdentityStrategy, 
		ISelectPlayerDeckStrategy selectDeckStrategy, 
		IChooseCardStrategy selectCardStrategy)
	{
		ArgumentNullException.ThrowIfNull(registerPlayerStrategy);
		ArgumentNullException.ThrowIfNull(selectPlayerIdentityStrategy);
		ArgumentNullException.ThrowIfNull(selectDeckStrategy);
		ArgumentNullException.ThrowIfNull(selectCardStrategy);
		RegisterPlayerStrategy = registerPlayerStrategy;
		SelectPlayerIdentityStrategy = selectPlayerIdentityStrategy;
		SelectDeckStrategy = selectDeckStrategy;
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
									SelectDeckStrategy, 
									SelectCardStrategy);
}
