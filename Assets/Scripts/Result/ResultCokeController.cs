using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ResultCokeController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite notExplosion;
    public Sprite explosion;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        transform.DOPunchPosition(new Vector3(0.1f, 0, 0), 3.0f, 40, 3)
            .OnComplete(OpenCoke);
    }

    private void OpenCoke()
    {
        if (ClickCounter.shakeCount >= 45)
        {
            spriteRenderer.sprite = explosion;
        }
        else
        {
            spriteRenderer.sprite = notExplosion;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
