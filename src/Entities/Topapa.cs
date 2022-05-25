namespace desafio.src.Entities
{
    public class Topapa : Hero
    {
        public Topapa (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Se defendeu com escudo ";
        }

        public string Attack(int Defesa){
           if (Defesa > 5) {
                return this.Name + " Usou o escudo e não teve dano: " + Defesa;

            }else{
                return this.Name + " Usou o escudo, mas não protegeu: " + Defesa;
            }
        }
    }
}