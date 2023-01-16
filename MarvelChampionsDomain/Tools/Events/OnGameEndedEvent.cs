namespace MarvelChampionsDomain.Tools.Events;

public sealed class OnGameEndedEvent : EventType
{
	public OnGameEndedEvent() : base(1, "OnGameEndedEvent") { }
}