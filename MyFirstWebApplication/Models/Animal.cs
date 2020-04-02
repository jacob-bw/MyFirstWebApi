using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyFirstWebApi.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
    }
}
