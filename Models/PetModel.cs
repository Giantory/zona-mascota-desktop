using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PetModel
    {
        int owner { get; set; }
        int specie { get; set; }
        int sex { get; set; }
        string name { get; set; }
        double weight { get; set; }
    }
}
