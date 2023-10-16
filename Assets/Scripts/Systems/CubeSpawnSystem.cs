using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

[BurstCompile]
public partial struct CubeSpawnSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        CubePrefabData cubePrefabData;
        var canRun = SystemAPI.TryGetSingleton<CubePrefabData>(out cubePrefabData);
        
        if(!canRun)
            return;

        state.Enabled = false;
        
        var entityCommandBuffer = SystemAPI.GetSingleton<EndInitializationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged).AsParallelWriter();

        var cubeSpawnJob = new CubeSpawnJob
        {
            nodeEntityPrefab = cubePrefabData.cubePrefabEntity,
            ECB = entityCommandBuffer
        }.Schedule(100, 2, state.Dependency);

        state.Dependency = cubeSpawnJob;
    }
}

[BurstCompile]
public partial struct CubeSpawnJob : IJobParallelFor
{
    public Entity nodeEntityPrefab;
    public EntityCommandBuffer.ParallelWriter ECB;
        
    [BurstCompile]
    public void Execute(int index)
    {
        var entity = ECB.Instantiate(0, nodeEntityPrefab);
        ECB.SetComponent(0, entity, new LocalTransform
        {
            Position = new float3(0, 0, 1) * index,
            Rotation = quaternion.identity,
            Scale = 1
        });
    }
}