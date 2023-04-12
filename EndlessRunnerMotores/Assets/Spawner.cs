using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawnPrefab;
    public float minX = 10f;
    public float maxX = 15f;
    public float yPos = -3.61f;
    public float minSpawnTime = 3f;
    public float maxSpawnTime = 6f;

    private void Start()
    {
        StartCoroutine(spawnDisk(Random.Range(minSpawnTime, maxSpawnTime), toSpawnPrefab));
    }

    private IEnumerator spawnDisk(float intervalo, GameObject disk)
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(disk, new Vector3(Random.Range(minX, maxX), yPos, 0), Quaternion.identity);
        StartCoroutine(spawnDisk(intervalo, disk));
    }
}
