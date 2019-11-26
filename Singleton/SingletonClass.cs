using System;

namespace Singleton
{
    public sealed class SingletonClass
    {
        private static SingletonClass _instance = null;
        private static readonly object _lock = new object();

        SingletonClass() { }

        public static SingletonClass SingleInstance
        {
            get
            {
                //The lock will allow only one thread at a time to access the block of code inside it.
                //If there is already a thread accessing the block of code inside the lock, the other threads 
                //will hold at this point until the first thread finishes her business inside that block
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonClass();
                    }
                    return _instance;
                }
            }
        }
    }
}
