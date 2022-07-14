using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoJogoRPG.scr.Entities
{
    public class Sandy : Hero
    {
        public Sandy(string Name, string Intelligence, string Gun, string Agility) : base(Name, Intelligence, Gun, Agility)
        {
            this.Name = Name;
            this.Intelligence = Intelligence;
            this.Gun = Gun;
            this.Agility = Agility;
        }
        public string Attack(int Bonus){

            if (Bonus > 2) {
                return $"- Tome isto, água-viva! E mais isto! ({this.Name})";
            } else {
                return $"- Todas águas-vivas estão me perseguindo! Ainda bem que minha roupa me protege contra os choques. ({this.Name})";
            }                     
        } 
    }
}