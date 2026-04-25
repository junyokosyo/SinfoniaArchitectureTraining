using Domain;

namespace Adaptor
{
    public class UnitSpawnerController
    {
        private readonly UnitStatusDomain _unitStatus;

        public UnitSpawnerController(UnitStatusDomain unitStatus)
        {
            _unitStatus = unitStatus;
        }

        public int GetMoveSpeed() => _unitStatus.MoveSpeed;
    }
}
