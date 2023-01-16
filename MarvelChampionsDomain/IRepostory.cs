namespace MarvelChampionsDomain.Entities;

public interface IRepository<T, U> where T : notnull
{
	List<U> GetAll();
	U GetById(T key);
	void Create(T key, U item);
	void Update(T key, U item);
	void Delete(T key);
}