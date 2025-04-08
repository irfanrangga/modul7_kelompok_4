using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JurnalMod7.TeamMembers_103022300100;

namespace JurnalMod7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            JsonMahasiswa.ReadJson("jurnal7_1_103022300100.json");
            //JsonTeamMembers.ReadJson("jurnal7_2_103022300100.json");
        }
    }
}
