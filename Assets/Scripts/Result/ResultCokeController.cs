using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ResultCokeController : MonoBehaviour
{
    //�摜�����ւ��p�ϐ�
    public SpriteRenderer spriteRenderer;
    public Sprite notExplosion;
    public Sprite explosion;

    //���ʉ��𐧌䂷��N���X���擾
    private ResultAudioController resultAudioController;

    //�����w�i�𐧌䂷��N���X���擾
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
