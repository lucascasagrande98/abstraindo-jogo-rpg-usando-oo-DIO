namespace Abstrair_jogo_rpg_usando_oo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
                return this.Name + " lançou sua magia";
            }

        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " lançou uma magia super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + " lançou uma magia fraca com bonus de " + Bonus;
            }
            
        }
    }
}