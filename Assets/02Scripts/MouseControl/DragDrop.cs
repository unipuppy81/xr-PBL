using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{ 
    public static Vector2 DefaultPos;

    private bool isClick;

    public Image jigSaw1;
    public Image jigSaw2;
    public Image jigSaw3;
    public Image jigSaw4;
    public Image jigSaw5;
    public Image jigSaw6;
    public Image jigSaw7;
    public Image jigSaw8;
    public Image jigSaw9;

    Image thisImg;


    /*
    private void OnMouseDown()
    {
        isClick = false;
    }

    private void OnMouseDrag()
    {
        Vector3 vpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vpos.z = 0f;
        transform.position = vpos;
    }

    private void OnMouseUp()
    {
        isClick = true;
    }
    */
    void Start()
    {
        thisImg = GetComponent<Image>();        
    }
  
    
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        DefaultPos = this.transform.position;
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


        if (this.transform.position.x >= 355 && this.transform.position.x <= 750 && 
            this.transform.position.y >= 780 && this.transform.position.y <= 1000)
        {

            jigSaw1.sprite = thisImg.sprite;
            
        }
        else if (this.transform.position.x >= 750 && this.transform.position.x <=1150 &&
            this.transform.position.y >= 780 && this.transform.position.y <= 1000)
        {

            jigSaw2.sprite = thisImg.sprite;

        }
        else if(this.transform.position.x >= 1150 && this.transform.position.x <= 1550 &&
            this.transform.position.y >= 780 && this.transform.position.y <= 1000)
        {

            jigSaw3.sprite = thisImg.sprite;

        }
        else if (this.transform.position.x >= 355 && this.transform.position.x <= 750 &&
            this.transform.position.y >= 560 && this.transform.position.y <= 780)
        {

            jigSaw4.sprite = thisImg.sprite;
        }
        else if (this.transform.position.x >= 750 && this.transform.position.x <= 1150 &&
            this.transform.position.y >= 560 && this.transform.position.y <= 780)
        {

            jigSaw5.sprite = thisImg.sprite;
        }
        else if (this.transform.position.x >= 1150 && this.transform.position.x <= 1550 &&
            this.transform.position.y >= 560 && this.transform.position.y <= 780)
        {

            jigSaw6.sprite = thisImg.sprite;
        }
        else if (this.transform.position.x >= 355 && this.transform.position.x <= 750 &&
            this.transform.position.y >= 320 && this.transform.position.y <= 560)
        {

            jigSaw7.sprite = thisImg.sprite;
        }
        else if (this.transform.position.x >= 750 && this.transform.position.x <= 1150 &&
            this.transform.position.y >= 320 && this.transform.position.y <= 560)
        {

            jigSaw8.sprite = thisImg.sprite;
        }
        else if (this.transform.position.x >= 1150 && this.transform.position.x <= 1550 &&
            this.transform.position.y >= 320 && this.transform.position.y <= 560)
        {
           
            jigSaw9.sprite = thisImg.sprite;
        }
        this.transform.position = DefaultPos;
    }








    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Img1"))
        {
            string collisionObject = collision.name;
            UnityEngine.Debug.Log("!@#");
        }
            //if(isClick && )
    }


}
