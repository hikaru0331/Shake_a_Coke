using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ResultCanvasController : MonoBehaviour
{
    //�����w�i���擾����ϐ�
    public GameObject whiteCanvasImage;
    private Image image;

    //�N���A�L�����o�X���擾
    public GameObject clearCanvas;
    public GameObject clearTitleButton;
    public GameObject clearText;

    //�Q�[���I�[�o�[�L�����o�X���擾
    public GameObject gameOverCanvas;
    public CanvasGroup gameOverCanvasGroup;

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
            clearCanvas.SetActive(true);

            clearTitleButton.transform.DOScale(1.5f, 1f)
                .SetEase(Ease.OutBounce);
            clearText.transform.DOScale(1.0f, 1f)
                .SetEase(Ease.OutBounce);
        }
        else
        {
            gameOverCanvas.SetActive(true);
            gameOverCanvasGroup.DOFade(1.0f, 2.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
