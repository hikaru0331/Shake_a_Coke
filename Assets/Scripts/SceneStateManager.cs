using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateManager : MonoBehaviour
{
    public static SceneStateManager instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //�^�C�g������J�n��ʂɑJ��
    public void LoadStartScene()
    {
        SceneManager.LoadScene("InGameStart");
    }

    //�J�n��ʂ���C���Q�[���ɑJ��
    public static void LoadInGameScene()
    {
        SceneManager.LoadScene("InGame");
    }

    //�C���Q�[������I����ʂɑJ��
    public static void LoadEndScene()
    {
        SceneManager.LoadScene("InGameEnd");
    }

    //�I����ʂ��烊�U���g�ɑJ��
    public void LoadResultScene()
    {
        SceneManager.LoadScene("Result");
    }

    //���U���g����^�C�g���ɑJ��
    public void LoadTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
}