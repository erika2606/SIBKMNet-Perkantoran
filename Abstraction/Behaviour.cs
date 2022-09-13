using System;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Abstraction
{
    public abstract class Behaviour
    {
        // replacement
        public abstract void Istirahat();
        public abstract void Kuota();
        public abstract void UangMakan();
        // modify
        public virtual void Work(string Name)
        {
            Console.WriteLine(Name + " sedang bekerja");
        }

        // overloading
        public void Living(string tinggal)
        {
            Console.WriteLine("bisa tinggal di " + tinggal);
        }

        public void Living(string tinggal1, string tinggal2)
        {
            Console.WriteLine("bisa tinggal di " + tinggal1 + " & di" + tinggal2);
        }
    }
}
