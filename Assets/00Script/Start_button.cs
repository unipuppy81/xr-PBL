using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start_button : MonoBehaviour
{

    public void SceneChange()
    {

        MySceneManager.Instance.ChangeScene("MainScene");

    }

}
