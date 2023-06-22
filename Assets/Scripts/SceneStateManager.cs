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

    //タイトルから開始画面に遷移
    public void LoadStartScene()
    {
        SceneManager.LoadScene("InGameStart");
    }

    //開始画面からインゲームに遷移
    public static void LoadInGameScene()
    {
        SceneManager.LoadScene("InGame");
    }

    //インゲームから終了画面に遷移
    public static void LoadEndScene()
    {
        SceneManager.LoadScene("InGameEnd");
    }

    //終了画面からリザルトに遷移
    public void LoadResultScene()
    {
        SceneManager.LoadScene("Result");
    }

    //リザルトからタイトルに遷移
    public void LoadTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
}