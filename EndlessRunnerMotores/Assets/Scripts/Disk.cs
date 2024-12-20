using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Disk : MonoBehaviour

{
    [SerializeField] private AudioClip interaction, interaction2;
    public float diskSpeed = -2f;
    public bool beenTouched = false;
    public Collider2D colid;
    private void Start()
    {
        colid = GetComponent<Collider2D>();
        Invoke(nameof(destroyDisk), 8);

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
            SoundManager.Instance.SFX(interaction);
        }

        if (collision.gameObject.CompareTag("RightCollider") && beenTouched == false)
        {
            transform.Rotate(0,0,90);
            diskSpeed -= 2;
            beenTouched = true;
            colid.enabled = false;
            SoundManager.Instance.SFX(interaction);
        }

        if (collision.gameObject.CompareTag("LeftCollider") && beenTouched == false)
        {
            transform.Rotate(0,0,270);
            diskSpeed -= 2;
            beenTouched = true;
            colid.enabled = false;
            SoundManager.Instance.SFX(interaction);
        }

        if (collision.gameObject.CompareTag("LoseTrigger"))
        {
            SoundManager.Instance.SFX(interaction2);
            SceneManager.LoadScene("Defeat");
            SoundManager.Instance.LoseMusic(false);
            Time.timeScale = 1f;
        }

    }

    private void destroyDisk()
    {
        Destroy(gameObject);
    }
}
