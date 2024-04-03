using Unity.Entities;
using Unity.Mathematics;

namespace Curvit.Demos.DOTS_Load
{
    public struct NodeComponent : IComponentData
    {
        public int Id;
        public float3 Position;
    }
}
