using System;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class Training : Pegawai
    {
        public Training(int id, string name, int age, bool gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override void Work(string Name)
        {
            base.Work(Name);
            Console.WriteLine(Name + " hanya bisa bekerja dikantor ");
        }
    }
}
