namespace desafio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }


         public override string Attack(){
            return this.Name + " Lançou Algo ";
        }

        public string Attack(int Bonus){
            if (Bonus > 6) {
                return this.Name + " Lançou algo super efetiva com bonus de: " + Bonus;

            }else{
                return this.Name + " Lançou algo com força fraca com bonus de: " + Bonus;
            }
              
        }
             
    }
}