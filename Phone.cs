namespace LearnPotentialDisposable
{
    sealed internal class Phone : ISomething, IDisposable
    {
        public string Name => nameof(Phone);

        public void Dispose()
        {
            Console.WriteLine("Disposing " + Name);
        }
    }
}