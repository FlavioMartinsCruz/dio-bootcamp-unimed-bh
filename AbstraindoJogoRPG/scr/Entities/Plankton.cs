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
        public string Attack(int ForcaAtaque){

            if (ForcaAtaque > 3) {
                return $"- Ei, água-viva! Tome isto! ({this.Name})";
            } else {
                return $"- Ah, não! Peguei uma água-viva, mas ela está me carregando para longe. ({this.Name})";
            }                     
        } 
    }
}