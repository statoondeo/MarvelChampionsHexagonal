using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectPlayerDeckStrategy
{
    void SelectDeckForPlayer(IPlayer player);
}