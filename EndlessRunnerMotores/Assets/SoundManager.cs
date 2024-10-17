using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    [SerializeField] private AudioSource menuMusicSource;
    [SerializeField] private AudioSource levelMusicBass;
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private AudioSource sfx;


    private void Awake()
    {
        Singleton();
    }
    private void Singleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }

        else Instance = this;
        DontDestroyOnLoad(this);
        StartCoroutine(FadeIn(menuMusicSource));
    }

    private IEnumerator FadeOut(AudioSource audioSource)
    {

        while (audioSource.volume > 0)
        {
            audioSource.volume -= Time.deltaTime / 1f;
            yield return null;
        }


    }
    private IEnumerator FadeIn(AudioSource audioSource)
    {
        Debug.Log("Fade in");


        while (audioSource.volume < 1f)
        {
            audioSource.volume += Time.deltaTime / 2f;
            yield return null;
        }
    }

    public void SwapMusic(bool falseToLevel)
    {
        Debug.Log("llegamo");
       if (!falseToLevel) 
        {
            StartCoroutine(FadeIn(levelMusicBass));
            StartCoroutine(FadeIn(levelMusic));
            StartCoroutine(FadeOut(menuMusicSource));
        }
       else
        {
            StartCoroutine(FadeOut(levelMusicBass));
            StartCoroutine(FadeOut(levelMusic));
            StartCoroutine(FadeIn(menuMusicSource));
        }
    }

    public void LoseMusic(bool falseToLose)
    {
        if(!falseToLose)
        {
            StartCoroutine(FadeOut(levelMusic));
        }
        else
        {
            StartCoroutine(FadeIn(levelMusic));
        }
    }

    public void SFX(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }

    public void PowerUp(bool falseToPowerUp)
    {
        if (!falseToPowerUp)
        {
            levelMusicBass.pitch = 0.6f;
            levelMusic.pitch = 0.6f;
        }
        else
        {
            levelMusicBass.pitch = 1f;
            levelMusic.pitch = 1f;
        }
    }
}
