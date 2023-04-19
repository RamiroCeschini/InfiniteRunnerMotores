using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
       transform.Translate(Input.GetAxis("Horizontal") *moveSpeed * Time.deltaTime, 0f, 0f);
    }
}
