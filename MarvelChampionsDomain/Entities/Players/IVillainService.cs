using MarvelChampionsDomain.Entities.Services;

namespace MarvelChampionsDomain.Entities.Players
{
	public interface IVillainService : IService
	{
		IVillainPlayer? Villain { get; }
		IVillainPlayer Register(IVillainPlayer villain);
	}
}