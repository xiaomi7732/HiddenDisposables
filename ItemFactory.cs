namespace LearnPotentialDisposable
{
    public class ItemFactory
    {
        public ISomething CreateSomething()
        {
            if (DateTime.Now.Second % 2 == 0)
            {
                return new Phone();
            }
            return new Paper();
        }
    }
}