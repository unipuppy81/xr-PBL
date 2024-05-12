using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class WireGame : MonoBehaviour
{
    public bool isClear;


    public GameObject Door;

    public GameObject Canvas;

    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;
    public GameObject image9;

    public int imageValue1;
    public int imageValue2;
    public int imageValue3;
    public int imageValue4;
    public int imageValue5;
    public int imageValue6;
    public int imageValue7;
    public int imageValue8;
    public int imageValue9;







    void Awake()
    {
        imageValue1 = 2;
        imageValue2 = 3;
        imageValue3 = 3;
        imageValue4 = 3;
        imageValue5 = 2;
        imageValue6 = 1;
        imageValue7 = 2;
        imageValue8 = 1;
        imageValue9 = 2;


        isClear = false;

    }
    
    void Start()
    {
        Invoke("SetRotation", 0f);
    }

    void Update()
    {

        
          //  Clear();

        if (isClear)
        {
            upDoor();
        }
    }

    public void Clear()
    {
        if (imageValue1 == 0 && imageValue2 == 0 && imageValue3 == 0 && imageValue4 == 0 && imageValue5 == 0 
            &&imageValue6 == 0 && imageValue7 == 0 && imageValue8 == 0 && imageValue9 == 0)
        {
            GameManager.isPanel = false;
            isClear = true;
            Canvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;

        }
        else
        {
            GameManager.isPanel = false;
            Canvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void upDoor()
    {
        Door.transform.position += Vector3.up * 0.1f;
    }
    public void SetRotation()
    {
       
        for (int i = 0; i < imageValue1; i++)
        {
            image1.transform.Rotate(new Vector3(0, 0, 90));
        }
        for (int i = 0; i < imageValue2; i++)
        {
            image2.transform.Rotate(new Vector3(0, 0, 90));
        }
        for (int i = 0; i < imageValue3; i++)
        {
            image3.transform.Rotate(new Vector3(0, 0, 90));
        }
        for(int i = 0; i < imageValue4; i++)
        {
            image4.transform.Rotate(new Vector3(0, 0, 90));
        }
        for (int i = 0; i < imageValue5; i++)
        {
            image5.transform.Rotate(new Vector3(0, 0, 90));
        }
        for (int i = 0; i < imageValue6; i++)
        {
            image6.transform.Rotate(new Vector3(0, 0, 90));
        }
        for (int i = 0; i < imageValue7; i++)
        {
            image7.transform.Rotate(new Vector3(0, 0, 90));
        }
        for (int i = 0; i < imageValue8; i++)
        {
            image8.transform.Rotate(new Vector3(0, 0, 90));
        }
        for (int i = 0; i < imageValue9; i++)
        {
            image9.transform.Rotate(new Vector3(0, 0, 90));
        }
    }

    public void RotationImage1()
    {
        //UnityEngine.Debug.Log(image1.transform.rotation.eulerAngles.z);
        imageValue1++;
        if(imageValue1 == 4)
        {
            imageValue1 = 0;   
        }

        image1.transform.Rotate(new Vector3(0, 0, 90));
    }
    public void RotationImage2()
    {
        imageValue2++;
        if (imageValue2 >= 4)
        {
            imageValue2 = 0;
        }

        image2.transform.Rotate(new Vector3(0, 0, 90));
    }
    public void RotationImage3()
    {
        imageValue3++;
        if (imageValue3 == 4)
        {
            imageValue3 = 0;
        }

        image3.transform.Rotate(new Vector3(0, 0, 90));
    }
    public void RotationImage4()
    {
        imageValue4++;
        if (imageValue4 == 4)
        {
            imageValue4 = 0;
        }


        image4.transform.Rotate(new Vector3(0, 0, 90));
    }
    public void RotationImage5()
    {
        imageValue5++;
        if (imageValue5 == 4)
        {
            imageValue5 = 0;
        }

        image5.transform.Rotate(new Vector3(0, 0, 90));
    }
    public void RotationImage6()
    {
        imageValue6++;
        if (imageValue6 == 4)
        {
            imageValue6 = 0;
        }

        image6.transform.Rotate(new Vector3(0, 0, 90));
    }
    public void RotationImage7()
    {
        imageValue7++;
        if (imageValue7 == 4)
        {
            imageValue7 = 0;
        }

        image7.transform.Rotate(new Vector3(0, 0, 90));
    }
    public void RotationImage8()
    {
        imageValue8++;
        if (imageValue8 == 4)
        {
            imageValue8 = 0;
        }

        image8.transform.Rotate(new Vector3(0, 0, 90));
    }
    public void RotationImage9()
    {


        imageValue9++;
        if (imageValue9 == 4)
        {
            imageValue9 = 0;
        }

        image9.transform.Rotate(new Vector3(0, 0, 90));
    }
}
