using MarvelChampionsDomain.Entities.Services;

namespace MarvelChampionsDomain.Tools;

public static class Logger
{
	public static void Log(string message) => ServiceLocator.Instance.Get<ILoggerService>().Log(message);
}
