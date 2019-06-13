using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class SingletonClass
    {
        private SingletonClass()
        {
            //constructor if needed
        }
        private static readonly object padlock = new object();
        private static SingletonClass instance = null;
        public static SingletonClass Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonClass();
                    }
                }
                return instance;
            }

    }
}
