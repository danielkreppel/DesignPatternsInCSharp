using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    //This is the structure that will manage the objects states through a list of Memento
    //The client uses this structure to save and restore states
    public static class CareTaker<T> where T : ICloneable
    {
        private static List<Memento<T>> mementoList = new List<Memento<T>>();

        public static void SaveState(Originator<T> orig)
        {
            mementoList.Add(orig.CreateMemento());
        }

        public static void RestoreState(Originator<T> orig, int checkpoint)
        {
            orig.RestoreMemento(mementoList[checkpoint]);
        }
    }
}
