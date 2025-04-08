using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JurnalMod7
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    class DataMahasiswa_103022300100
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Courses> courses { get; set; }
    }

    public class JsonMahasiswa
    {
        public static void ReadJson(string filePath)
        {
            string jsonFile = File.ReadAllText(filePath);
            DataMahasiswa_103022300100 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_103022300100>(jsonFile);

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
