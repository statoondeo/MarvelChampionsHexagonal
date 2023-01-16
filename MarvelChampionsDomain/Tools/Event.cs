namespace MarvelChampionsDomain.Tools;

public sealed class Event
{
    private Action<IEventArg>? Listener;
    public Event() { }
    public void Raise(IEventArg eventArg) => Listener?.Invoke(eventArg);
	public void RegisterListener(Action<IEventArg> callback)
	{
		ArgumentNullException.ThrowIfNull(callback);
		Listener += callback;
	}
	public void UnregisterListener(Action<IEventArg> callback)
	{
		ArgumentNullException.ThrowIfNull(callback);
		Listener -= callback;
	}
}
