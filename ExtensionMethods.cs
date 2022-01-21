namespace LearnPotentialDisposable
{
    internal static class ExtensionMethods
    {
        public static void TryDispose<T>(this T target)
            where T : class
        {
            if (target is not null && target is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}