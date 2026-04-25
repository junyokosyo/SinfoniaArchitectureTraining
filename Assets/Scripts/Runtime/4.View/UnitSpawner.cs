using UnityEngine;
using UnityEngine.UI;
using Adaptor;
namespace View
{

    public class UnitSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject unitPrefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Transform target;
        [SerializeField] private Button spawnButton;

        private UnitSpawnerController _controller;

        public void Initialize(UnitSpawnerController controller)
        {
            _controller = controller;
            spawnButton.onClick.AddListener(Spawn);
        }

        private void Spawn()
        {
            var unit = Instantiate(unitPrefab, spawnPoint.position, spawnPoint.rotation);
            unit.GetComponent<UnitView>().Initialize(target.position, _controller.GetMoveSpeed());
        }
    }

}
