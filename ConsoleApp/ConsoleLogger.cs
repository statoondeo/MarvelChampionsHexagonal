using MarvelChampionsDomain.Entities.Services;

namespace MarvelChampionsDomain.Tools;

public sealed class ConsoleLogger : ILoggerService
{
	public void Log(string message) => Console.WriteLine(message);
}
