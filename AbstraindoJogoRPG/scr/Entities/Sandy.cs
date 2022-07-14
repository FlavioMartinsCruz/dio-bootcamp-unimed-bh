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
                return $"{this.Name}: - Tome isto, água-viva! E mais isto!";
            } else {
                return $"{this.Name}: - As águas-vivas estão me perseguindo! Ainda bem que minha roupa protege contra os choques.";
            }                     
        } 
    }
}