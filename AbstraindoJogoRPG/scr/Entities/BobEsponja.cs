namespace AbstraindoJogoRPG.scr.Entities
{
    public class BobEsponja : Hero
    {
        public BobEsponja(string Name, string Intelligence, string Gun, string Agility) : base(Name, Intelligence, Gun, Agility)
        {
            this.Name = Name;
            this.Intelligence = Intelligence;
            this.Gun = Gun;
            this.Agility = Agility;
        }
        public string Attack(int Bonus){

            if (Bonus > 3) {
                return $"- Estoooou prooonto! ({this.Name})";
            } else {
                return $"- Ahhhh, que choque estou levando! ({this.Name})";
            }                     
        } 
    }
}