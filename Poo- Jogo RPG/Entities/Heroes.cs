namespace Poo__Jogo_RPG.Entities;

    public abstract class Heroes
    {
        public Heroes (string name, int level,string heroeType)
        {
            this.Name= name;
            this.Level = level;
            this.HeroeType = heroeType;

        }

        public string Name;
        public int Level;
        public string HeroeType;

        public override string ToString()
        {
            return this.Name + " " + this.Level+ " " + this.HeroeType;
        }
        public virtual string Attack ()
        {
            return this.Name +" "+  "Atacou com a sua espada";
        }
    }

