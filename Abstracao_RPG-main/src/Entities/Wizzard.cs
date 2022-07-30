using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao_RPG.src.Entities
{
public class Wizzard : Hero
{

    public Wizzard(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }
    public override string Attack()
    {
        return this.Name + " Lançou magia";
    }
    public string Attack(int Bonus)
    {
        if (Bonus > 6)
        {
            return this.Name + " Lançou magia super efetiva com bonus de " + Bonus;
        }
        else
        {
            return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
        }
    }
}
}