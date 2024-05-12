using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InvenManager : MonoBehaviour
{
    public GameObject battery;
    public GameObject Oil;
    public GameObject tape;
    public GameObject controlRoomKey;
    public GameObject cardKey;


    public GameObject tmpbattery;
    public GameObject tmpOil;
    public GameObject tmptape;
    public GameObject tmpcontrolRoomKey;
    public GameObject tmpcardKey;
   



    // Update is called once per frame
    void Update()
    {
        SetInventory();
    }

    void SetInventory()
    {
        if (Player.isBattery)
        {
            battery.SetActive(true);
            tmpbattery.SetActive(false);
        }
        if (Player.isLub)
        {
            cardKey.SetActive(true);
            tmpcardKey.SetActive(false);
        }
        if (Player.hasKey1)
        {
            controlRoomKey.SetActive(true);
            tmpcontrolRoomKey.SetActive(false);
        }
        if (Player.istape)
        {
            tape.SetActive(true);
            tmptape.SetActive(false);
        }
        if (Player.isidCard)
        {
            Oil.SetActive(true);
            tmpOil.SetActive(false);
        }
        /*
        if (Player.isBattery)
        {
            garbageKey.SetActive(true);
            tmpgarbageKey.SetActive(false);
        }
        */
    }
}
