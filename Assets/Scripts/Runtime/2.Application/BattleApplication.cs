using UnityEngine;
using Domain;
using System;
namespace UseCase.BattleSystem
{
    public class BattleApplication
    {
        private readonly  System.Random _random = new System.Random();

        public void Attack(UnitDomain attacker, UnitDomain target)
        {
            var isCritical = _random.NextDouble() < attacker.Status.CriticalChance;
            var multiplier = isCritical ? attacker.Status.CriticalDamage : 1f;
            var damage = (int)(attacker.Status.AttackPower * multiplier);

            target.TakeDamage(damage);
        }
    }
}
