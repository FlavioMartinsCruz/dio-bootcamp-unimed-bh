namespace AbstraindoJogoRPG.scr.Entities
{
    public class Hero
    {
        public Hero(string Name, string Intelligence, string Gun, string Agility){
            this.Name = Name;
            this.Intelligence = Intelligence;
            this.Gun = Gun;
            this.Agility = Agility;
        }

      public string Name;
      public string Intelligence;
      public string Gun;
      public string Agility;

      public override string ToString(){
        return $"{this.Name} {this.Intelligence} {this.Gun} {this.Agility}";
      }

      public virtual string Attack(){
        return $"{this.Name}, que possui inteligência {Intelligence} e agilidade {Agility}, atacou com a sua {this.Gun}";
      }
    }
}