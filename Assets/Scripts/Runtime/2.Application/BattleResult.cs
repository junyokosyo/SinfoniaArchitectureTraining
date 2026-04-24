using UnityEngine;
using Domain;

namespace UseCase.BattleSystem
{
    public class BattleResult
    {
        public bool IsTargetDead { get; }
        public int DamageDealt { get; }

        public BattleResult(bool isDead, int damage)
        {
            IsTargetDead = isDead;
            DamageDealt = damage;
        }
    }
}
