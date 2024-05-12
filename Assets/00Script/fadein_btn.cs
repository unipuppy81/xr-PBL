using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadein_btn : MonoBehaviour
{
    float time = -3;
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }


    void Update()
    {
        if (time < 3f)
        {
            GetComponent<Image>().color = new Color(1, 1, 1, (time / 3));
            if (time > 0.3f)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
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
        GetComponent<Image>().color = new Color(1, 1, 1, 1);
        this.gameObject.SetActive(true);
        time = 0;
    }
}
