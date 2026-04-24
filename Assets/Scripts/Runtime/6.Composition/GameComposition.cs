using UnityEngine;
using Domain;
using InfraStructure;
namespace Composition
{
    public class GameComposition : MonoBehaviour
    {
        [SerializeField] private UnitDataSO unitData;

        void Awake()
        {
            var repository = new UnitRepository();
            var unitStatus = repository.GetUnitStatus(unitData);
            var unit = new UnitDomain("unit_a" ,unitStatus);

            Debug.Log($"名前: {unit.Status.Name}");
            Debug.Log($"HP: {unit.CurrentHp}");

            unit.TakeDamage(1);
            Debug.Log($"ダメージ後HP: {unit.CurrentHp}");
            Debug.Log($"死亡: {unit.IsDead}");
        }
    }
}