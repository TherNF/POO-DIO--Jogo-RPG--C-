using static System.Console;
using Poo__Jogo_RPG.Entities;

Knight Arus= new Knight (" Arus",42, "Knight");
WhiteWizard Jenica = new WhiteWizard (" Jenica", 99, "White Wizard");
Ninja Wedge = new Ninja ( " Wedge", 50," Ninja");
BlackWizard Topapa = new BlackWizard ( "Topapa", 100, "Black Wizard");


WriteLine($"Personagem: {Arus}");
WriteLine(Arus.Attack());
WriteLine(Topapa.Attack());
WriteLine(Topapa.Attack(8));

WriteLine();
WriteLine($"Personagem: {Wedge}");
WriteLine(Wedge.Attack());
WriteLine (Jenica.Attack(50));



