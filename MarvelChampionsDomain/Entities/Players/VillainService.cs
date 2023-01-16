using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Players;

public sealed class VillainService : IVillainService
{
	public IPlayer? Villain { get; private set; }
	public VillainService() { }
	public IPlayer Register(IPlayer villain)
	{
		Villain = villain ?? throw new ArgumentNullException(nameof(villain));
		Logger.Log($"VillainService.Register -> {villain}");
		return villain;
	}
}