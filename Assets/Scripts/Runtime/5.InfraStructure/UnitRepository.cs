using UnityEngine;
using Domain;

namespace InfraStructure
{
    public class UnitRepository
    {
        private readonly UnitDataConverter _converter = new UnitDataConverter();

        public UnitStatusDomain GetUnitStatus(UnitDataSO so)
        {
            return _converter.Convert(so);
        }
    }
}
