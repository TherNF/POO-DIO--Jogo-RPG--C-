namespace Poo__Jogo_RPG.Entities;

public class WhiteWizard : Heroes
{
    public WhiteWizard(string name, int level, string heroeType) : base(name, level, heroeType)
    {
        this.Name = name;
        this.Level = Level;
        this.HeroeType = HeroeType;
    }

    public override string Attack()
    {
        return this.Name + " Lançou sua magia";
    }

    public string Attack(int Bonus)
    {

        if (Bonus > 6)
        {
            return this.Name +" "+ "Lançou uma magia super efetiva com bônus de  " + Bonus;
        }
        else
        {
            return this.Name + " " +"Lançou uma magia de baixa intensidade com bônus de " + Bonus;
        }
    }
}
   