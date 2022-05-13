namespace rpg_game_objects.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
        }

        public override string Attack()
        {
            return this.Name + " atacou com shuriken";
        }

        public string Attack(int Bonus)
        {
             if (Bonus > 6)
            {
                return this.Name + " ataque super efetivo com shuriken com bônus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " atacou com shuriken com bônus de ataque de " + Bonus;
            }
        }

    }
}