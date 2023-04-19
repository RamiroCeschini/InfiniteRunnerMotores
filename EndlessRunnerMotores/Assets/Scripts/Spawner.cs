using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] toSpawnPrefabs;
    public float diSpawnPosition;
    public float spawnPositionX;
    public float spawnPositionY;
    private GameObject block;
    public float spawnTime;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnBlock),0f, spawnTime);
    }

    private void SpawnBlock()
    {
        int blocknumber = Random.Range(0, toSpawnPrefabs.Length);
        block = toSpawnPrefabs[blocknumber];
        Debug.Log("Spawned" + blocknumber);
        Instantiate(block, new Vector3(spawnPositionX, spawnPositionY, 0), Quaternion.identity);
    }
}
