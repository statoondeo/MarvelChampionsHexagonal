namespace MarvelChampionsDomain.Entities.Services;

public interface ILoggerService : IService
{
    void Log(string message);
}
