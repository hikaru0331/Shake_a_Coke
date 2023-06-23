using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ResultCanvasController : MonoBehaviour
{
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FadeCanvas()
    {
        image = GetComponent<Image>();

        gameObject.SetActive(true);
        image.DOFade(0.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
