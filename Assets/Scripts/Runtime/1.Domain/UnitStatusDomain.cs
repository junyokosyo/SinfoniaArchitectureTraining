using UnityEngine;
using System;

namespace Domain
{
    public readonly struct UnitStatusDomain : IEquatable<UnitStatusDomain>
    {
        public string Name { get; }
        public int Cost { get; }
        public int MaxHp { get; }
        public int Defense { get; }
        public int MoveSpeed { get; }
        public int AttackPower { get; }
        public float AttackRange { get; }
        public float AttackInterval { get; }
        public float CriticalChance { get; }
        public float CriticalDamage { get; }

        public UnitStatusDomain(
           string name,
           int cost,
           int maxHp,
           int defense,
           int moveSpeed,
           int attackPower,
           float attackRange,
           float attackInterval,
           float criticalChance,
           float criticalDamage)
        {
            Name = name;
            Cost = cost;
            MaxHp = maxHp;
            Defense = defense;
            MoveSpeed = moveSpeed;
            AttackPower = attackPower;
            AttackRange = attackRange;
            AttackInterval = attackInterval;
            CriticalChance = criticalChance;
            CriticalDamage = criticalDamage;
        }

        public bool Equals(UnitStatusDomain other) => Name == other.Name;
    }
}
