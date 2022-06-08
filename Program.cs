using Abstrair_jogo_rpg_usando_oo.src.Entities;

internal class Program
{
  private static void Main(string[] args)
  {
    Knight knight = new Knight("Arus", 42, "Knight");
    Wizard wizard = new Wizard("Jennica", 42, "White Wizard");
    Console.WriteLine(wizard.Attack(1));
    Console.WriteLine(wizard.Attack(7));
  }
}