using UnityEngine;
using Domain;
namespace InfraStructure
{
    public class UnitDataConverter
    {
        public UnitStatusDomain Convert(UnitDataSO so)
        {
            return new UnitStatusDomain(
                so.unitName,
                so.cost,
                so.maxHp,
                so.defense,
                so.moveSpeed,
                so.attackPower,
                so.attackRange,
                so.attackInterval,
                so.criticalChance,
                so.criticalDamage
            );
        }
    }
}
