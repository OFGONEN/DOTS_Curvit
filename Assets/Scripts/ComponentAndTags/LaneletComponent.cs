using Unity.Entities;
using UnityEngine;

namespace Curvit.Demos.DOTS_Load
{
    public struct LaneletComponent : IComponentData
    {
        public int ID;
        public OSMLaneletDataFlag OsmLaneletDataFlag;
        public int SpeedLimit;
        public int WayReference_Left;
        public int WayReference_Right;
        public int WayReference_Middle;
    }
}
