using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Services;

public interface IPlayerService : IService
{
    List<IHeroPlayer> Players { get; }
	IHeroPlayer First { get; }
	IHeroPlayer Register(IHeroPlayer player);
    void SetFirst(int playerIndex);
    void Unregister(IHeroPlayer player);
    void NextPlayerSetToFirst();
	IHeroPlayer GetById(EntityId id);
}
