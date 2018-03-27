using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoeSpawnController : MonoBehaviour {

    public FoeUnit FoePrefab;
    public FoeEntity[] FoeEntities;
    private float MinSpawnRadius = 12f;
    private float MaxSpawnRadius = 14f;
    private const int MAX_FOES = 10;
    private List<FoeUnit> FoeBuffer = new List<FoeUnit>();

    private void Start()
    {
        for (int i = 0; i < MAX_FOES; i++)
        {
            var foe = Instantiate<FoeUnit>(FoePrefab);
            FoeBuffer.Add(foe);
            foe.KillMe();
        }
    }

    private void SpawnFoe()
    {
        FoeUnit foe = null;
        foreach(var entry in FoeBuffer)
        {
            if (!entry.IsAlive)
            {
                foe = entry;
            }
        }
        if (!foe) { return; }
        var dataIndex = Random.Range(0, FoeEntities.Length);
        foe.UnitData = FoeEntities[dataIndex];
        foe.Initialize();
        PlaceObjectAtRandomPosition(foe.transform);
    }

    private void PlaceObjectAtRandomPosition(Transform obj)
    {
        var radius = Random.Range(MinSpawnRadius, MaxSpawnRadius);
        var angle = Random.Range(0f, 2*Mathf.PI);
        var x = radius * Mathf.Sin(angle);
        var z = radius * Mathf.Cos(angle);
        obj.position = transform.position + new Vector3(x, 0, z);
    }

    private void Update()
    {
        SpawnFoe();
    }
}
