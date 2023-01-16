namespace MarvelChampionsApplication;

public interface IUseCasePresenter<in T> where T : class
{
    void Present(T output);
}
