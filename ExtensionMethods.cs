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

        public static PotentialDisposable<T> MakeDisposable(this T target)
            where T: class
        {
            if(T is null)
            {
                throw new ArgumentNullException(nameof(target));
            }
            return new PotentialDisposable<T>(target);
        }
    }
}