using ConsoleApp;

using MarvelChampionsApplication.CreateAndStartNewGame;
using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Tools;

using MarvelChampionsInfrastructure;

ServiceLocator.Instance.Register<ILoggerService>(new ConsoleLogger());
ServiceLocator.Instance.Register<IMediatorService>(new Mediator());
ServiceLocator.Instance.Register<IPlayerService>(new PlayerService());
ServiceLocator.Instance.Register<IVillainService>(new VillainService());
ServiceLocator.Instance.Register<ICardService>(new CardService());
ServiceLocator.Instance.Register<IIdentityRepository>(new IdentityMemoryRepository());
ServiceLocator.Instance.Register<ICardSetRepository>(new MemoryCardSetRepository());

new CreateAndStartNewGameUseCase(new CreateAndStartNewGameUseCaseInput()
{
	RegisterPlayerPresenter = new ConsoleRegisterPlayerPresenter(),
	SelectPlayerIdentityPresenter = new ConsoleListIdentitiesPresenter(),
	SelectDeckPresenter = new ConsoleSelectDeckPresenter(),
	SelectCardStrategy = new ConsoleChooseCardStrategy()
}).Execute();

