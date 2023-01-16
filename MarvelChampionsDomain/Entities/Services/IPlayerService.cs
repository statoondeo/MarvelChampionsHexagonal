using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Services;

public interface IPlayerService : IService
{
    IReadOnlyList<IPlayer> Players { get; }
    IPlayer First { get; }
    IPlayer Register(IPlayer player);
    void SetFirst(int playerIndex);
    void Unregister(IPlayer player);
    void NextPlayerSetToFirst();
    IPlayer GetById(EntityId id);
}
