using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalMod7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DataMahasiswa_103022300100 mahasiswa = JsonMahasiswa.ReadJson<DataMahasiswa_103022300100>("jurnal7_1_103022300100.json");

            Console.WriteLine($"Nama: {mahasiswa.firstName} {mahasiswa.lastName}");
            Console.WriteLine($"Gender: {mahasiswa.gender}");
            Console.WriteLine($"Age: {mahasiswa.age}");
            Console.WriteLine($"Address: {mahasiswa.address.streetAddress} {mahasiswa.address.city} {mahasiswa.address.state}");
            Console.WriteLine($"Courses: ");
            int i = 1;
            foreach (var matkul in mahasiswa.courses)
            {
                Console.WriteLine($"MK {i} {matkul.code} - {matkul.name}");
                i++;
            }

        }
    }
}
