using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Games;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsDomain.Entities.Builders;

public sealed class GameBuilder
{
	private ICommand? SetupCommand;
	private readonly IRegisterPlayerStrategy RegisterPlayerStrategy;
	private readonly ISelectOneAndOnlyOneCard SelectVillainIdentityStrategy;
	private readonly ISelectCardSetStrategy SelectOneAndOnlyOneCard;
	private readonly IChooseCardStrategy SelectCardStrategy;

	public GameBuilder(
		IRegisterPlayerStrategy registerPlayerStrategy,
		ISelectOneAndOnlyOneCard selectOneAndOnlyOneCard,
		ISelectCardSetStrategy selectPlayerDeckStrategy,
		IChooseCardStrategy selectCardStrategy)
	{
		ArgumentNullException.ThrowIfNull(registerPlayerStrategy);
		ArgumentNullException.ThrowIfNull(selectOneAndOnlyOneCard);
		ArgumentNullException.ThrowIfNull(selectPlayerDeckStrategy);
		ArgumentNullException.ThrowIfNull(selectCardStrategy);

		RegisterPlayerStrategy = registerPlayerStrategy;
		SelectVillainIdentityStrategy = selectOneAndOnlyOneCard;
		SelectOneAndOnlyOneCard = selectPlayerDeckStrategy;
		SelectCardStrategy = selectCardStrategy;
	}
	public GameBuilder WithSetupCommand(ICommand setupCommand)
	{
		SetupCommand = setupCommand ?? throw new ArgumentNullException(nameof(setupCommand));
		return this;
	}
	public Game Build() => new(SetupCommand!, 
									RegisterPlayerStrategy, 
									SelectOneAndOnlyOneCard,
									SelectVillainIdentityStrategy,
									SelectCardStrategy);
}
