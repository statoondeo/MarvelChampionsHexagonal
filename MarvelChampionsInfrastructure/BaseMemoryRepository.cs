using MarvelChampionsDomain.Entities;

namespace MarvelChampionsInfrastructure;

public abstract class BaseMemoryRepository<T, U> : IRepository<T, U> where T : notnull
{
	protected readonly IDictionary<T, U> Atlas;
	protected BaseMemoryRepository() => Atlas = new Dictionary<T, U>();
	public void Create(T key, U item)
	{
		ArgumentNullException.ThrowIfNull(key);
		ArgumentNullException.ThrowIfNull(item);
		Atlas.TryAdd(key, item);
	}
	public void Delete(T key)
	{
		ArgumentNullException.ThrowIfNull(key);
		if (Atlas.Remove(key)) return;
		throw new KeyNotFoundException();
	}
	public List<U> GetAll() => Atlas.Values.ToList();
	public U GetById(T key)
	{
		ArgumentNullException.ThrowIfNull(key);
		if (Atlas.TryGetValue(key, out U? item)) return item;
		throw new KeyNotFoundException();
	}
	public void Update(T key, U item)
	{
		ArgumentNullException.ThrowIfNull(key);
		ArgumentNullException.ThrowIfNull(item);
		if (!Atlas.ContainsKey(key)) throw new KeyNotFoundException();
		Atlas[key] = item;
	}
}