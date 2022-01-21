// Reference: https://docs.microsoft.com/en-us/archive/msdn-magazine/2016/november/net-framework-hidden-disposables

using LearnPotentialDisposable;

ItemFactory factory = new ItemFactory();

// Method 1: Check the IDisposable manually
ISomething createdItem = factory.CreateSomething();
Console.WriteLine("#1 Create {0}, is IDisposable: {1}", createdItem, createdItem is IDisposable);
if (createdItem is IDisposable disposable)
{
    disposable.Dispose();
}

// Method 2: Use an extension method
ISomething createdItem2 = factory.CreateSomething();
Console.WriteLine("#2 Create {0}, is IDisposable: {1}", createdItem2, createdItem2 is IDisposable);
createdItem2.TryDispose();

// Method 3: Use potential disposable wrapper
ISomething createdItem3 = factory.CreateSomething();
using (new PotentialDisposable<ISomething>(createdItem3))
{
    Console.WriteLine("#3 Create {0}, is IDisposable: {1}", createdItem3, createdItem3 is IDisposable);
}