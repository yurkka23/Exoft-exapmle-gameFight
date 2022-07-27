using System;
namespace HeroBattle.Models.Heros
{
    public class IronMan : BaseHero
    {
        public override int Armor { get; set; } = 15;

        public override int Damage { get; set; } = 5;
    }
}
