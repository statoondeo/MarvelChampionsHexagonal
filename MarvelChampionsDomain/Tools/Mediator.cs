using MarvelChampionsDomain.Tools.EventArgs;

namespace MarvelChampionsDomain.Tools;

public sealed class Mediator : IMediatorService
{
	private readonly IDictionary<Type, Event> EventsAtlas;
	public Mediator() => EventsAtlas = new Dictionary<Type, Event>();
	private Event GetOrAdd<T>() where T : EventType
	{
		if (!EventsAtlas.TryGetValue(typeof(T), out Event? newEvent))
		{
			newEvent = new Event();
			EventsAtlas.Add(typeof(T), newEvent);
		}
		return newEvent;
	}
	public void Raise<T>() where T : EventType => GetOrAdd<T>().Raise(EventArg.Empty);
	public void Raise<T>(IEventArg eventArg) where T : EventType => GetOrAdd<T>().Raise(eventArg);
	public void RegisterListener<T>(Action<IEventArg> callback) where T : EventType => GetOrAdd<T>().RegisterListener(callback);
	public void UnregisterListener<T>(Action<IEventArg> callback) where T : EventType => GetOrAdd<T>().UnregisterListener(callback);
}