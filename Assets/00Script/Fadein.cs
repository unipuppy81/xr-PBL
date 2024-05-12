using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadein : MonoBehaviour
{
    float time = -3;
    public float _color = 0;

    void Update()
    {
        if (time < 3f)
        {
            GetComponent<Image>().color = new Color(_color, _color, _color, (time / 3) * 0.7f);
        }
        else
        {
            time = 10;
            this.gameObject.SetActive(true);
        }
        time += Time.deltaTime;
    }
    public void resetAnim()
    {
        GetComponent<Image>().color = new Color(_color, _color, _color, 0.7f);
        this.gameObject.SetActive(true);
        time = 0;
    }
}
