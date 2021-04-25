using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPWindowsForms.Constant
{
    public enum OrderStatusesEnum
    {
        Created = 1,
        ReadyForDelivery,
        OnMap,
        Active,
        Closed
    }

    public enum StoreTypesEnum
    {
        FreightWarehouse = 1,
        DeliveryWarehouse
    }

    public enum CarStatusesEnum
    {
        InStore = 1,
        InDrive,
        Inactive
    }
}
