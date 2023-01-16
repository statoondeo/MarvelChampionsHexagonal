using MarvelChampionsDomain.Entities.Services;

namespace MarvelChampionsDomain.Tools;

public sealed class ServiceLocator
{
    #region Singleton

    public static readonly ServiceLocator Instance = new();
    private ServiceLocator() { }

    #endregion

    private readonly IDictionary<Type, IService> Services = new Dictionary<Type, IService>();

    public T Register<T>(T service) where T : IService
    {
        Services.Add(typeof(T), service);
        return service;
    }
    public void UnRegister<T>() where T : IService => Services.Remove(typeof(T));
    public T Get<T>() where T : IService => (T)Services[typeof(T)];
}
