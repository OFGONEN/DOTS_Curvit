using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Curvit.Demos.DOTS_Load
{
    public struct OSMPrefabProperties : IComponentData
    {
        public Entity OSMNodePrefabEntity;
        public Entity OSMLaneletPrefabEntity;
        public float NodeSize;
    }
}
