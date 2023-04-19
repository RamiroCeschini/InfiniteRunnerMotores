using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyThis", 8f);
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }

   
}
