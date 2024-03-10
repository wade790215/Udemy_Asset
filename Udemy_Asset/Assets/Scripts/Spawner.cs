using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject medPrefab;
    public Terrain terrain;
    TerrainData terrinData;

    void Start()
    {
        TerrainData terrainData = terrain.terrainData;
        InvokeRepeating("CreateEgg", 1, 1f);
        InvokeRepeating("CreateMed", 1, 0.1f);
    }

    private void CreateEgg()
    {
        int x = Random.Range(0, (int)terrain.terrainData.size.x);
        int z = Random.Range(0, (int)terrain.terrainData.size.z);
        Vector3 position = new Vector3(x, 0, z);
        position.y = terrain.SampleHeight(position) + 10;
        Instantiate(eggPrefab, position, Quaternion.identity);
    }

    private void CreateMed()
    {
        int x = Random.Range(0, (int)terrain.terrainData.size.x);
        int z = Random.Range(0, (int)terrain.terrainData.size.z);
        Vector3 position = new Vector3(x, 0, z);
        position.y = terrain.SampleHeight(position) + 10;
        Instantiate(medPrefab, position, Quaternion.identity);
    }
}
