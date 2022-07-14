using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoJogoRPG.scr.Entities
{
    public class Plankton : Hero
    {
        public Plankton(string Name, string Intelligence, string Gun, string Agility) : base(Name, Intelligence, Gun, Agility)
        {
            this.Name = Name;
            this.Intelligence = Intelligence;
            this.Gun = Gun;
            this.Agility = Agility;
        }
        public string Attack(int Bonus){

            if (Bonus > 3) {
                return $"{this.Name}: - Ei, água-viva! Tome isto!";
            } else {
                return $"{this.Name}: - Ah, não! peguei uma água-viva, mas ela está me carregando para longe.";
            }                     
        } 
    }
}