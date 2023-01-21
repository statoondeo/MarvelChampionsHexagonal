using MarvelChampionsApplication.Strategies;

using MarvelChampionsDomain.Entities.Builders;
using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsApplication.CreateAndStartNewGame;

public sealed class CreateAndStartNewGameUseCase : IUseCase
{
    private readonly CreateAndStartNewGameUseCaseInput Input;
    public CreateAndStartNewGameUseCase(CreateAndStartNewGameUseCaseInput input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Input = input;
    }
    public void Execute()
    {
        IGameService gameService = ServiceLocator.Instance.Register<IGameService>(
            new GameBuilder(
                new RegisterPlayerStrategy(Input.RegisterPlayerPresenter!),
                new SelectPlayerIdentityStrategy(Input.SelectPlayerIdentityPresenter!),
                new SelectVillainIdentityStrategy(Input.SelectVillainIdentityPresenter!),
                new SelectPlayerDeckStrategy(Input.SelectDeckPresenter!),
                new SelectVillainDeckStrategy(Input.SelectDeckPresenter!),
                Input.SelectCardStrategy!)
            .WithSetupCommand(
                new CompositeCommandBuilder()
                .WithCommand(new SelectPlayerIdentityCompositeCommand())
                .WithCommand(new InitPlayersLifeCompositeCommand())
                .WithCommand(new SelectRandomFirstPlayerCommand())
                .WithCommand(new SetAsidePlayerObligationsCompositeCommand())
                .WithCommand(new SetAsidePlayerNemesisCompositeCommand())
                .WithCommand(new SetPlayerDeckCompositeCommand())
                .WithCommand(new ShufflePlayerDeckCompositeCommand())
                .WithCommand(new SelectVillainIdentityCompositeCommand())
                .WithCommand(new InitVillainsLifeCompositeCommand())
                .WithCommand(new SetVillainDeckCompositeCommand())
                .WithCommand(new ResolveMainSchemeSetupCommand())
                .WithCommand(new ShuffleVillainDeckCompositeCommand())
                .WithCommand(new PlayerDrawHandCompositeCommand())
                .WithCommand(new PlayerMulliganCompositeCommand())
                .WithCommand(new PlayerSetupCompositeCommand())
                .Build())
            .Build());

        // Démarrage de la partie
        gameService.Start();
    }
}
