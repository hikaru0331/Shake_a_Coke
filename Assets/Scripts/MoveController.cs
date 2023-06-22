using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveController : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveCoke()
    {
        if(transform.position.y <= 0)
            transform.DOMoveY(3.0f, 0.25f)
                .SetEase(Ease.InOutBack);
        else
            transform.DOMoveY(-3.0f, 0.25f)
                .SetEase(Ease.InOutBack);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
