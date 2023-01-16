namespace MarvelChampionsDomain;

public class Error
{
	public Error(string id, string message)
	{
		Id = id;
		Message = message;
	}

	public string Id { get; }
	public string Message { get; }
}
