using System;

namespace Domain
{
    public class UnitDomain
    {
        public string ID => _id;
        public UnitStatusDomain Status { get; }
        public int CurrentHp { get; private set; }

        public UnitDomain(string id, UnitStatusDomain status)
        {
            _id = id;
            Status = status;
            CurrentHp = status.MaxHp;
        }

        public void TakeDamage(int amount)
        {
            var actualDamage = Math.Max(0, amount / Math.Max(1, Status.Defense));
            CurrentHp = Math.Max(0, CurrentHp - actualDamage);
        }

        public bool IsDead => CurrentHp <= 0;

        private readonly string _id;
    }
}
