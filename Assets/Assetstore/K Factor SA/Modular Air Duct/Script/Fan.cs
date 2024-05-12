using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public static float fanSpeed;
    public static bool fanOn;
    // Start is called before the first frame update
    void Start()
    {
        fanSpeed = 0.0f;
        fanOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fanOn)
        {
            transform.Rotate(0, 0, 180.0f * Time.deltaTime);
        }
    }
}
