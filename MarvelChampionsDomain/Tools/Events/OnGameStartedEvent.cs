namespace MarvelChampionsDomain.Tools.Events;

public sealed class OnGameStartedEvent : EventType
{
	public OnGameStartedEvent() : base(0, "OnGameStarted") { }
}
