using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoJogoRPG.scr.Entities
{
    public class Patrick : Hero
    {
        public Patrick(string Name, string Intelligence, string Gun, string Agility) : base(Name, Intelligence, Gun, Agility)
        {
            this.Name = Name;
            this.Intelligence = Intelligence;
            this.Gun = Gun;
            this.Agility = Agility;
        }
        public string Attack(int Bonus){

            if (Bonus > 4) {
                return $"{this.Name}: - Venha cá, água-viva! Não me faça correr!";
            } else {
                return $"{this.Name}: - Bob Esponja, socooorro! Tira elas de cima de mim.";
            }                     
        } 
    }
}