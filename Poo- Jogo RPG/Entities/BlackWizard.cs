namespace Poo__Jogo_RPG.Entities;

public class BlackWizard: Heroes
{
    public BlackWizard(string name, int level, string heroeType) : base(name, level, heroeType)
    {
        this.Name = name;
        this.Level = Level;
        this.HeroeType = HeroeType;
    }
    public override string Attack(){
        return this.Name +  " Lançou sua magia negra";
    }
    public string Attack( int Bonus){

        if (Bonus> 7){
            return this.Name +" "+  "Lançou uma magia catrastófica com bônus de  " + Bonus ;
        }
        else
        {
            return this.Name +" "+ "Lançou uma magia de baixa intensidade " + Bonus;
        }
    }
}
