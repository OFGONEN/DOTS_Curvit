using Unity.Entities;

namespace Curvit.Demos.DOTS_Load
{
    public struct WayComponent : IComponentData
    {
        public int ID;
        public OSMWayDataFlag OsmWayDataFlag;
    }
}
