using MarvelChampionsDomain.Entities.Services;

namespace ConsoleApp;

public sealed class FileLogger : ILoggerService
{
	private readonly string FilePath;

	public FileLogger(string filePath)
	{
		if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentNullException(nameof(filePath));
		FilePath = filePath;
		File.WriteAllLines(FilePath, new string[1] { string.Empty });
	}

	public void Log(string message) => File.AppendAllLines(FilePath, new List<string>() { message });
}
