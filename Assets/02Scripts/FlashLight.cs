using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    Light flash_light;
    Transform tr;
    KeyCode[] KeyCode_List;
    // Start is called before the first frame update
    void Awake()
    {
        flash_light = GetComponent<Light>();
        tr = this.transform;

        Key_Depoly();
    }

    // Update is called once per frame
    void Key_Depoly()
    {
        KeyCode_List = new KeyCode[10];
    }
}
