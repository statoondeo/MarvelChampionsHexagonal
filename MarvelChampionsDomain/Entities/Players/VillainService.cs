using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Players;

public sealed class VillainService : IVillainService
{
	public IVillainPlayer? Villain { get; private set; }
	public VillainService(IVillainPlayer villain) => Register(villain);
	public IVillainPlayer Register(IVillainPlayer villain)
	{
		Villain = villain ?? throw new ArgumentNullException(nameof(villain));
		Logger.Log($"VillainService.Register -> {villain}");
		return villain;
	}
}