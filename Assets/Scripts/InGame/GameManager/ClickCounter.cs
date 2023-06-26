using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    public static int shakeCount;

    //コルーチン用に連続でクリックをカウントしないための変数
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

        yield return new WaitForSeconds(0.1f);

        isShaking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isShaking)
            return;

        if (Input.GetMouseButtonDown(0) 
            || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            isShaking = true;

            cokeController.MoveCoke();
            cokeController.PlayShakeSound();

            StartCoroutine("ShakeCounter");           
        }
    }
}
