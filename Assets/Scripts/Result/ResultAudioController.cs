using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ResultAudioController : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip notExplosionSound;
    public AudioClip explosionSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayNotExplosionSound()
    {
        audioSource.PlayOneShot(notExplosionSound);
    }

    public void PlayExplosionSound()
    {
        audioSource.PlayOneShot(explosionSound);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
