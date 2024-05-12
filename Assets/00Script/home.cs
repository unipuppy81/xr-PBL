using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour
{
    public void SceneChange()
    {
        MySceneManager.Instance.ChangeScene("StartScene");

    }

}
