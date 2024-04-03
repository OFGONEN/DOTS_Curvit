using Unity.Entities;

namespace Curvit.Demos.DOTS_Load
{
    [InternalBufferCapacity(32)]
    public struct NodeReferenceBufferComponent : IBufferElementData
    {
        public OSMNodeData OSMNodeData;
    }
}
