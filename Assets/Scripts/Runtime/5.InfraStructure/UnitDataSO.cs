using UnityEngine;

namespace InfraStructure
{
    [CreateAssetMenu(fileName = "UnitDataSO", menuName = "Scriptable Objects/UnitDataSO")]
    public class UnitDataSO : ScriptableObject
    {
        public string unitName;
        public int cost;
        public int maxHp;
        public int defense;
        public int moveSpeed;
        public int attackPower;
        public float attackRange;
        public float attackInterval;
        public float criticalChance;
        public float criticalDamage;
    }
}
