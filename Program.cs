using static System.Console;
using rpg_game_objects.src.Entities;

class Program
{
    static void Main()
    {
        Knight arus = new Knight("Arus", 23, "Knight",400,100);
        Wizard wizard = new Wizard("Jenica", 23, "White Wizard",300,200);

        WriteLine(arus.Attack());
        WriteLine(wizard.Attack(5));
    }
}