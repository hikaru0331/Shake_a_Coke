using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    public static int shakeCount = 45;

    //�R���[�`���p�ɘA���ŃN���b�N���J�E���g���Ȃ����߂̕ϐ�
    private bool isShaking;

    public GameObject coke;
    private CokeController cokeController;

    // Start is called before the first frame update
    void Start()
    {        
        cokeController = coke.GetComponent<CokeController>();
    }

    IEnumerator ShakeCounter()
    {
        if(isShaking)
            shakeCount++;

        yield return new WaitForSeconds(0.25f);

        isShaking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isShaking)
        {
            isShaking = true;

            cokeController.MoveCoke();
            cokeController.PlayShakeSound();

            StartCoroutine("ShakeCounter");           
        }
    }
}
