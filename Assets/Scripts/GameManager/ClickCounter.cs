using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    public static int shakeCount;

    //�R���[�`���p�ɘA���ŃN���b�N���J�E���g���Ȃ����߂̕ϐ�
    private bool isShake;

    public GameObject coke;
    private MoveController moveController;

    // Start is called before the first frame update
    void Start()
    {        
        moveController = coke.GetComponent<MoveController>();
    }

    IEnumerator ShakeCounter()
    {
        if(isShake)
            shakeCount++;

        yield return new WaitForSeconds(0.25f);

        isShake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isShake)
        {
            isShake = true;

            moveController.MoveCoke();

            StartCoroutine("ShakeCounter");           
        }
    }
}
