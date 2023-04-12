using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Disk : MonoBehaviour

{
    public float diskSpeed = -2f;
    public bool beenTouched = false;
    public Collider2D colid;
    private void Start()
    {
        colid = GetComponent<Collider2D>();
        Invoke(nameof(destroyDisk), 4);

    }
    void Update()
    {

        transform.Translate(0f, diskSpeed * Time.deltaTime, 0f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("UpCollider") && beenTouched == false)
        {
            transform.Rotate(0,0,180);
            colid.enabled = false;
            beenTouched = true;
        }

        if (collision.gameObject.CompareTag("RightCollider") && beenTouched == false)
        {
            transform.Rotate(0,0,90);
            diskSpeed -= 2;
            beenTouched = true;
            colid.enabled = false;
        }

        if (collision.gameObject.CompareTag("LeftCollider") && beenTouched == false)
        {
            transform.Rotate(0,0,270);
            diskSpeed -= 2;
            beenTouched = true;
            colid.enabled = false;
        }

        if (collision.gameObject.CompareTag("LoseTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    private void destroyDisk()
    {
        Destroy(gameObject);
    }
}
