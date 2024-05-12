using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragDropCam : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static Vector2 DefaultPos2;

    private bool isClick;

    public Image jigSaw1;
    public Image jigSaw2;
    public Image jigSaw3;

    public int a, b, c;

    Image thisImg;

    public string name;

    [Header("Image On")]
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;


    void Start()
    {
        thisImg = GetComponent<Image>();
        a = 9;
        b = 9;
        c = 9;
        //jigSaw1 = GetComponent<Image>();
        //jigSaw2 = GetComponent<Image>();
        //jigSaw3 = GetComponent<Image>();
    }

    void Update()
    {
        name = thisImg.sprite.name;
        imgName();
        imgOn();
    }

    public void imgName()
    {
        if(jigSaw1.sprite.name == "Rescue")
        {
            a = 0;
        }
        if(jigSaw2.sprite.name == "Rescue")
        {
            b = 0;
        }
        if (jigSaw3.sprite.name == "Rescue")
        {
            c = 0;
        }
        if (jigSaw1.sprite.name == "Truth")
        {
            a = 1;
        }
        if (jigSaw2.sprite.name == "Truth")
        {
            b = 1;
        }
        if (jigSaw3.sprite.name == "Truth")
        {
            c = 1;
        }
        if (jigSaw1.sprite.name == "Escape")
        {
            a = 2;
        }
        if (jigSaw2.sprite.name == "Escape")
        {
            b = 2;
        }
        if (jigSaw3.sprite.name == "Escape")
        {
            c = 2;
        }
        if (jigSaw1.sprite.name == "Ventilation")
        {
            a = 3;
        }
        if (jigSaw2.sprite.name == "Ventilation")
        {
            b = 3;
        }
        if (jigSaw3.sprite.name == "Ventilation")
        {
            c = 3;
        }
        if (jigSaw1.sprite.name == "Generate")
        {
            a = 4;
        }
        if (jigSaw2.sprite.name == "Generate")
        {
            b = 4;
        }
        if (jigSaw3.sprite.name == "Generate")
        {
            c = 4;
        }
        if (jigSaw1.sprite.name == "Open")
        {
            a = 5;
        }
        if (jigSaw2.sprite.name == "Open")
        {
            b = 5;
        }
        if (jigSaw3.sprite.name == "Open")
        {
            c = 5;
        }
        if (jigSaw1.sprite.name == "Evacuate")
        {
            a = 6;
        }
        if (jigSaw2.sprite.name == "Evacuate")
        {
            b = 6;
        }
        if (jigSaw3.sprite.name == "Evacuate")
        {
            c = 6;
        }
        if (jigSaw1.sprite.name == "Patrol")
        {
            a = 7;
        }
        if (jigSaw2.sprite.name == "Patrol")
        {
            b = 7;
        }
        if (jigSaw3.sprite.name == "Patrol")
        {
            c = 7;
        }
    }

    public void playMovie()
    {
        if (a == 9 && b == 9 && c== 9)
        {
            SceneManager.LoadScene("Ending_5");
        }
        else if(a == 0 && b== 9 && c == 9)
        {
            SceneManager.LoadScene("Ending_1");
        }
        else if (a == 2 && b == 0 && c == 0)
        {
            SceneManager.LoadScene("Ending_4");
        }
        else if (a == 1 && b == 2 && c == 9)
        {
            SceneManager.LoadScene("Ending_3");
        }
        else if (a == 4 && b == 5 && c == 9)
        {
            SceneManager.LoadScene("Ending_6");
        }
        else if (a == 0 && b == 4 && c == 5)
        {
            SceneManager.LoadScene("Ending_2");
        }
        else if(a == 0 && b == 6 && c == 1)
        {
            SceneManager.LoadScene("Ending_7");
        }
        else
        {
            SceneManager.LoadScene("Ending_7");
        }
    }

    public void imgOn()
    {
        if (SceneManager1.isRescue)
        {
            image1.SetActive(true);
        }
        else if (!SceneManager1.isRescue)
        {
            image1.SetActive(false);
        }

        if (SceneManager1.isTruth)
        {
            image2.SetActive(true);
        }
        else if (!SceneManager1.isTruth)
        {
            image2.SetActive(false);
        }

        if (SceneManager1.isEscape)
        {
            image3.SetActive(true);
        }
        else if (!SceneManager1.isEscape)
        {
            image3.SetActive(false);
        }

        if (SceneManager1.isVentilation)
        {
            image4.SetActive(true);
        }
        else if (!SceneManager1.isVentilation)
        {
            image4.SetActive(false);
        }

        if (SceneManager1.isGenerate)
        {
            image5.SetActive(true);
        }
        else if (!SceneManager1.isGenerate)
        {
            image5.SetActive(false);
        }

        if (SceneManager1.isOpen)
        {
            image6.SetActive(true);
        }
        else if (!SceneManager1.isOpen)
        {
            image6.SetActive(false);
        }

        if (SceneManager1.isEvacuate)
        {
            image7.SetActive(true);
        }
        else if (!SceneManager1.isEvacuate)
        {
            image7.SetActive(false);
        }

        if (SceneManager1.isPatrol)
        {
            image8.SetActive(true);
        }
        else if (!SceneManager1.isPatrol)
        {
            image8.SetActive(false);
        }
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        DefaultPos2 = this.transform.position;
        
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;


    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        UnityEngine.Debug.Log("X : " + this.transform.position.x + "Y : " + this.transform.position.y);


        if (this.transform.position.x >= 85 && this.transform.position.x <= 454 &&
           this.transform.position.y >= 545 && this.transform.position.y <= 920)
        {

            jigSaw1.sprite = thisImg.sprite;

        }
        else if (this.transform.position.x >= 505 && this.transform.position.x <= 864 &&
            this.transform.position.y >= 545 && this.transform.position.y <= 920)
        {

            jigSaw2.sprite = thisImg.sprite;

        }
        else if (this.transform.position.x >= 945 && this.transform.position.x <= 1320 &&
            this.transform.position.y >= 545 && this.transform.position.y <= 920)
        {

            jigSaw3.sprite = thisImg.sprite;

        }
        this.transform.position = DefaultPos2;
    }
}
