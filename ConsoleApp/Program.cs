using ConsoleApp;

using MarvelChampionsApplication.CreateAndStartNewGame;

using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Tools;

using MarvelChampionsInfrastructure;

ServiceLocator.Instance.Register<ILoggerService>(new FileLogger(@"log.txt"));
ServiceLocator.Instance.Register<IMediatorService>(new Mediator());
ServiceLocator.Instance.Register<IPlayerService>(new PlayerService());
ServiceLocator.Instance.Register<IVillainService>(new VillainService(new VillainPlayer()));
ServiceLocator.Instance.Register<ICardService>(new CardService());
ServiceLocator.Instance.Register<IHeroIdentityRepository>(new HeroIdentityMemoryRepository());
ServiceLocator.Instance.Register<IVillainIdentityRepository>(new VillainIdentityMemoryRepository());
ServiceLocator.Instance.Register<ICardSetRepository>(new MemoryCardSetRepository());

new CreateAndStartNewGameUseCase(new CreateAndStartNewGameUseCaseInput()
{
	RegisterPlayerPresenter = new ConsolePresenter(),
	SelectOneAndOnlyOneCardPresenter = new ConsolePresenter(),
	SelectCardSetPresenter = new ConsolePresenter(),
	SelectAtLeastOneCardPresenter = new ConsolePresenter()
}).Execute();

