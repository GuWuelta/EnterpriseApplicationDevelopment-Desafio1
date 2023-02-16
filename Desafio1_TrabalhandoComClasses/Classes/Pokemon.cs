using Desafio1_TrabalhandoComClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_TrabalhandoComClasses.Classes
{
    public class Pokemon : IPokemon
    {
        public string Trainer { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public string Attack { get; set; }

        public static Pokemon createPokemon(string trainer, string name, string type, string attack)
        {
            return new Pokemon
            {
                Trainer = trainer,
                Name = name,
                Type = type,
                Attack = attack
            };
        }
    }
}
