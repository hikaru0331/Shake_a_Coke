using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ResultCanvasController : MonoBehaviour
{
    public GameObject whiteCanvasImage;
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FadeWhiteCanvas()
    {
        image = whiteCanvasImage.GetComponent<Image>();

        whiteCanvasImage.SetActive(true);
        image.DOFade(0.0f, 2.0f)
            .OnComplete(ShowUI);
    }

    private void ShowUI()
    {
        if (ClickCounter.shakeCount >= 45)
        {
            
        }
        else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
