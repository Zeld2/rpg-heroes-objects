namespace rpg_game_objects.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
        }

        public override string Attack()
        {
            return this.Name + " atacou com espada";
        }

        public string Attack(int Bonus)
        {
             if (Bonus > 6)
            {
                return this.Name + " ataque super efetivo com espada com bônus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " atacou com espada com bônus de ataque de " + Bonus;
            }
        }

    }
}