using MarvelChampionsDomain.Entities.Services;

namespace MarvelChampionsDomain.Entities.Players
{
	public interface IVillainService : IService
	{
		IPlayer? Villain { get; }

		IPlayer Register(IPlayer villain);
	}
}