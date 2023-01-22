using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Basics;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Enums;
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

		ICardService cardService = ServiceLocator.Instance.Get<ICardService>();
		foreach (LocationEnum location in new List<LocationEnum> {  LocationEnum.Exil,
																	LocationEnum.Battlefield,
																	LocationEnum.Hand,
																	LocationEnum.Discard,
																	LocationEnum.Deck,
																	LocationEnum.MainScheme})
		{
			Logger.Log(location.ToString());
			cardService
				.GetCards(card => ServiceLocator.Instance.Get<IPlayerService>().First.Id.Equals(card.Owner) && location.Equals(card.Location))
				.ForEach(card => Logger.Log("\t" + card.ToString()));
		}
	}
}
