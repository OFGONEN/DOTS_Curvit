using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class CubePrefabBaker : MonoBehaviour
{
    public GameObject cubePrefab;

    class CubeBaker : Baker<CubePrefabBaker>
    {
        public override void Bake(CubePrefabBaker authoring)
        {
            var entity = GetEntity(authoring.cubePrefab, TransformUsageFlags.Dynamic);

            var cubePrefabData = GetEntity(TransformUsageFlags.None);
            
            AddComponent(cubePrefabData, new CubePrefabData
            {
                cubePrefabEntity = entity
            });
        }
    }
}

public struct CubePrefabData : IComponentData
{
    public Entity cubePrefabEntity;
}