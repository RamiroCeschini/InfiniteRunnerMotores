using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float floorSpeed = -2f;
    public float spawnPosition;
    public float diSpawnPosition;


    void Update()
    {
        transform.Translate(0f, floorSpeed * Time.deltaTime, 0f);

        if (transform.position.y <= diSpawnPosition)
        {
            transform.position = new Vector3(transform.position.x, spawnPosition, 0f);
        }
    }
}
