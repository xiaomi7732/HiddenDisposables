namespace LearnPotentialDisposable;

internal sealed class PotentialDisposable<T> : IDisposable where T : class
{
    public T Instance { get; }
    public PotentialDisposable(T instance)
    {
        Instance = instance ?? throw new ArgumentNullException(nameof(instance));
    }
    public void Dispose()
    {
        if (Instance is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}