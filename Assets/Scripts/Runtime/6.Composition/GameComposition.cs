using UnityEngine;
using InfraStructure;
using Adaptor;
using View;
namespace Composition
{
    public class GameComposition : MonoBehaviour
    {
        [SerializeField] private UnitDataSO unitData;
        [SerializeField] private UnitSpawner unitSpawner;

        void Awake()
        {
            var repository = new UnitRepository();
            var unitStatus = repository.GetUnitStatus(unitData);

            var controller = new UnitSpawnerController(unitStatus);
            unitSpawner.Initialize(controller);
        }
    }
}