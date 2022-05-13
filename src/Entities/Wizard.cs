namespace rpg_game_objects.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
        }

        public override string Attack()
        {
            return this.Name + " lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com bônus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " lançou magia com bônus de ataque de " + Bonus;
            }
        }

    }
}