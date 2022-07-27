using System;
using HeroBattle.Services;

namespace HeroBattle.Models.Heros
{
    public class Tor : BaseHero
    {
        public override int Armor { get; set; } = 4;

        public override int Damage { get; set; } = 16;

        public override void AddSuperPower(ISuperPowerService powerService, int power)
        {
            power *= 2;
            base.AddSuperPower(powerService, power);
        }
    }
}
