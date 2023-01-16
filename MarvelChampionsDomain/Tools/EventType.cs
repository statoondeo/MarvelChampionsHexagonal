using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools.Events;

namespace MarvelChampionsDomain.Tools;

public abstract class EventType : BaseEnum<EventType>
{
	public static readonly EventType OnGameStarted = new OnGameStartedEvent();
	protected EventType(int value, string name) : base(value, name) { }
}
