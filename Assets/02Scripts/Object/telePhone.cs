using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class telePhone : MonoBehaviour
{
    public TMP_InputField NumberField;
    public GameObject TelephonePanel;

    public GameObject RescuePanel1;
    public GameObject EvacuatePanel1;

    public string textNum;
    void Start()
    {
        NumberField.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        NumberField.text = textNum;
        //checkNum();
    }
    public void EvacuatePanelExit()
    {
        GameManager.isPanel = false;
        EvacuatePanel1.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void RescuePanelExit()
    {
        GameManager.isPanel = false;
        RescuePanel1.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void checkNum()
    {
        if(NumberField.text == "95123")
        {
            // ¾À 1 È¹µæ
            GameManager.isPanel = false;
            textNum = " ";
            TelephonePanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            RescuePanel1.SetActive(true);
            GameManager.isPanel = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if(NumberField.text == "16503")
        {
            // ¾À 2 È¹µæ
            EvacuatePanel1.SetActive(true);
            GameManager.isPanel = false;
            textNum = " ";
            TelephonePanel.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            // Æ²¸²
            UnityEngine.Debug.Log("Æ²¸²");
            GameManager.isPanel = false;
            TelephonePanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }        
    }

    public void DeleteNum()
    {
        int a = textNum.Length;
        a--;
        string b = textNum.Substring(0, a);
        textNum = b;
    }

    public void ExitNum()
    {
        textNum = " ";
        TelephonePanel.SetActive(false);
        GameManager.isPanel = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Input1()
    {
        textNum += "1";
    }

    public void Input2()
    {
        textNum += "2";
    }

    public void Input3()
    {
        textNum += "3";
    }

    public void Input4()
    {
        textNum += "4";
    }

    public void Input5()
    {
        textNum += "5";
    }

    public void Input6()
    {
        textNum += "6";
    }

    public void Input7()
    {
        textNum += "7";
    }

    public void Input8()
    {
        textNum += "8";
    }

    public void Input9()
    {
        textNum += "9";
    }

    public void Input0()
    {
        textNum += "0";
    }
}
