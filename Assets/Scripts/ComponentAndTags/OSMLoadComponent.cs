using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Curvit.Demos.DOTS_Load
{
    public struct OSMLoadComponent : IComponentData
    {
        public NativeArray<OSMNodeData> OSMNodeDataArray;
        public NativeArray<OSMWayData> OSMWayDataArray;
        public NativeArray<OSMLaneletData> OSMLaneletDataArray;
        public NativeList<int> OSMWayNodeRefDataList;
    }
}
