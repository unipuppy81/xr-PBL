using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ending1 : MonoBehaviour
{
    public string _end_num = "1";
   
    public void SceneChange()
    {
        string scene = "Ending_" + _end_num;
    }

}
