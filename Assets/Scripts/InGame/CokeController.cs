using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CokeController : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip shakeSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void MoveCoke()
    {
        if (transform.position.y <= 0)
            transform.DOMoveY(3.0f, 0.1f)
                .SetEase(Ease.InOutBack);
        else
            transform.DOMoveY(-3.0f, 0.1f)
                .SetEase(Ease.InOutBack);
    }

    public void PlayShakeSound()
    {
        audioSource.PlayOneShot(shakeSound);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
