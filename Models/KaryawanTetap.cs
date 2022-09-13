using System;
using SIBKMNet.Abstraction;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class KaryawanTetap : Pegawai, IBehaviour
    {
        public KaryawanTetap(int id, string name, int age, bool gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void Salary(string Name)
        {
            Console.WriteLine(Name + " mendapatkan gaji sebesar Rp. 5.500.000");
        }
    }
}
