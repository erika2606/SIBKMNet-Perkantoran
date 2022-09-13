using System;
using SIBKMNet.Abstraction;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class Pegawai : Behaviour
    {
        public Pegawai(int Id, string Name, int Age, bool Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public Pegawai()
        {

        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public bool Gender { get; protected set; }

        public override void Istirahat()
        {
            Console.WriteLine("istirahat dijam kerja");
        }

        public override void Kuota()
        {
            Console.WriteLine("mendapatkan kuota sebesar 30GB");
        }

        public override void UangMakan()
        {
            Console.WriteLine("mendapatkan uang makan Rp. 50.000");
        }
    }
}
