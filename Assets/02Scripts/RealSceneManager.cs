using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RealSceneManager : MonoBehaviour
{
    public void goGameScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void goMainScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
