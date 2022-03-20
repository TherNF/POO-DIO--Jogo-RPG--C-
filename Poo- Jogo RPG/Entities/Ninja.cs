namespace Poo__Jogo_RPG.Entities;

public class Ninja: Heroes
{
public Ninja (string name, int level, string heroeType) : base(name, level, heroeType)
{
    this.Name = name;
    this.Level = level;
    this.HeroeType = heroeType;
}
    
}