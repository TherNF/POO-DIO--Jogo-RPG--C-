namespace Poo__Jogo_RPG.Entities;

public class Knight:Heroes
{
    public Knight (string name, int level, string heroeType) : base(name, level, heroeType)
{
    this.Name = name;
    this.Level = level;
    this.HeroeType = heroeType;
}
    
}
