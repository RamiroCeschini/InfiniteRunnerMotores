using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float powerUpSpeed = -2f;
    public GameObject powerUpVisual;
    public Score _score;

    private void Start()
    {
        _score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
    void Update()
    {
        transform.Translate(0f, powerUpSpeed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("UpCollider") || collision.CompareTag("LeftCollider") || collision.CompareTag("RightCollider"))
        {
            Destroy(powerUpVisual);
            Time.timeScale = 0.5f;
            Invoke("NormalTime", 3f);
            _score.SumarPuntos(100);
        }
    }

    void NormalTime()
    {
        Destroy(gameObject);
        Time.timeScale = 1f;
    }
}
