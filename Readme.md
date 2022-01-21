# Hidden Disposables

This is a refresh of the implementations discussed here:

<https://docs.microsoft.com/en-us/archive/msdn-magazine/2016/november/net-framework-hidden-disposables>

The implementations is still valid but aged (so will this one), and I gave it a refresh.

## TL;DR

This is useful in case you have a Factory that returns an abstraction of an object by interface. The interface doesn't implement IDisposable since there's no enforce for implementation to have one, for example:

* interface ISomething;
* class Paper : ISomething;
* class Phone : ISomething, IDisposable;

And factory:

* class ItemFactory that creates `ISomething` (in this implementation, it depends on whether the current second is a even or odd number).

There are several solutions, refer to [Program.cs](./Program.cs) for details. But basically:

* Let the caller decide - that will become tedious;
* Provide an extension method - I came this up;
* Use a wrapper class of [PotentialDisposable](./PotentialDisposable.cs);

Have fun!
