using MarvelChampionsDomain.Entities.Services;

namespace MarvelChampionsDomain.Tools
{
	public interface IMediatorService : IService
	{
		void Raise<T>(IEventArg eventArg) where T : EventType;
		void Raise<T>() where T : EventType;
		void RegisterListener<T>(Action<IEventArg> callback) where T : EventType;
		void UnregisterListener<T>(Action<IEventArg> callback) where T : EventType;
	}
}