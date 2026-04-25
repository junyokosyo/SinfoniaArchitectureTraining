using UnityEngine;
using UnityEngine.AI;
namespace View
{
    public class UnitView : MonoBehaviour
    {
        private NavMeshAgent _agent;

        public void Initialize(Vector3 targetPosition, int moveSpeed)
        {
            _agent = GetComponent<NavMeshAgent>();
            _agent.speed = moveSpeed;
            _agent.SetDestination(targetPosition);
        }
    }

}
