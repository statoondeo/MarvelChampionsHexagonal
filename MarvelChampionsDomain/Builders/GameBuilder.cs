using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Games;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsDomain.Entities.Builders;

public sealed class GameBuilder
{
	private ICommand? SetupCommand;
	private readonly IRegisterPlayerStrategy RegisterPlayerStrategy;
	private readonly ISelectOneAndOnlyOneCard SelectOneAndOnlyOneCard;
	private readonly ISelectAtLeastOneCardStrategy SelectAtLeastOneCard;
	private readonly ISelectCardSetStrategy SelectCardSetStrategy;

	public GameBuilder(
		IRegisterPlayerStrategy registerPlayerStrategy,
		ISelectOneAndOnlyOneCard selectOneAndOnlyOneCard,
		ISelectAtLeastOneCardStrategy selectAtLeastCardStrategy,
		ISelectCardSetStrategy selectCardSetStrategy)
	{
		ArgumentNullException.ThrowIfNull(registerPlayerStrategy);
		ArgumentNullException.ThrowIfNull(selectOneAndOnlyOneCard);
		ArgumentNullException.ThrowIfNull(selectAtLeastCardStrategy);
		ArgumentNullException.ThrowIfNull(selectCardSetStrategy);

		RegisterPlayerStrategy = registerPlayerStrategy;
		SelectOneAndOnlyOneCard = selectOneAndOnlyOneCard;
		SelectAtLeastOneCard = selectAtLeastCardStrategy;
		SelectCardSetStrategy = selectCardSetStrategy;
	}
	public GameBuilder WithSetupCommand(ICommand setupCommand)
	{
		SetupCommand = setupCommand ?? throw new ArgumentNullException(nameof(setupCommand));
		return this;
	}
	public Game Build() => new(SetupCommand!, 
									RegisterPlayerStrategy,
									SelectOneAndOnlyOneCard,
									SelectAtLeastOneCard,
									SelectCardSetStrategy);
}
