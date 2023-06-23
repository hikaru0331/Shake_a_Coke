using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ResultCokeController : MonoBehaviour
{
    //画像差し替え用変数
    public SpriteRenderer spriteRenderer;
    public Sprite notExplosion;
    public Sprite explosion;

    //効果音を制御するクラスを取得
    private ResultAudioController resultAudioController;

    //白い背景を制御するクラスを取得
    public GameObject whiteCanvasImage;
    private ResultCanvasController resultCanvasController;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        resultAudioController = GetComponent<ResultAudioController>();

        resultCanvasController = whiteCanvasImage.GetComponent<ResultCanvasController>();

        transform.DOPunchPosition(new Vector3(0.1f, 0, 0), 3.0f, 40, 3)
            .OnComplete(OpenCoke);
    }

    private void OpenCoke()
    {
        resultCanvasController.FadeCanvas();

        if (ClickCounter.shakeCount >= 45)
        {
            resultAudioController.PlayExplosionSound();
            spriteRenderer.sprite = explosion;
        }
        else
        {
            resultAudioController.PlayNotExplosionSound();
            spriteRenderer.sprite = notExplosion;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
