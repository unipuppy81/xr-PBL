using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadein_text : MonoBehaviour
{
    float time = -3;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        text.color = new Color(1, 1, 1, 0);
    }


    void Update()
    {
        if (time < 3f)
        {
            this.gameObject.SetActive(true);
            text.color = new Color(1, 1, 1, (time / 3));
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
        GameObject.Find("Ending").GetComponent<Text>().color = new Color(1, 1, 1, 1);
        this.gameObject.SetActive(true);
        time = 0;
    }
}
