using Desafio1_TrabalhandoComClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_TrabalhandoComClasses.Interfaces
{
    public interface IPokemon
    {
        public string Trainer { get; set; }
        
        public string Name { get; set; }

        public string Type { get; set; }

        public string Attack { get; set; }

    }
}
