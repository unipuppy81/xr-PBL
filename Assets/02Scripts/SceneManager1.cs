using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class SceneManager1 : MonoBehaviour
{
    static public bool isRescue;
    static public bool isTruth;
    static public bool isEscape;
    static public bool isVentilation;
    static public bool isGenerate;
    static public bool isOpen;
    static public bool isEvacuate;
    static public bool isPatrol;

    [Header("Panel")]
    public GameObject WireGamePanel;
    public GameObject JigSawGamePanel;
    public GameObject PausePanel;
    public GameObject CamPanel;
    public GameObject TelephonePanel;
    public GameObject InvenPanel;
    public GameObject Paper1Panel;
    public GameObject Paper2Panel;
    public GameObject Paper3Panel;
    public GameObject FileDummyPanel;
    public GameObject GetItemPanel;
    public GameObject puzzlePanelExplan;
    public GameObject fanPanel;
    public GameObject okPatrolPanel;

    [Header("Film")]
    public GameObject TruthPanel;
    public GameObject EscapePanel;
    public GameObject VentilationPanel;
    public GameObject GenaratePanel;
    public GameObject OpenPanel;
    public GameObject RescuePanel;
    public GameObject EvacuatePanel;
    public GameObject PatrolPanel;

    private int pauseNum;
    private int camNum;
    private int invenNum;

    public void Start()
    {
        isRescue = false;
        isTruth = false;
        isEscape = false;
        isVentilation = false;
        isGenerate = false;
        isOpen = false;
        isEvacuate = false;
        isPatrol = false;

        pauseNum = 0;
        camNum = 0;
        invenNum = 0;
    }

    public void PuzzlePanelExplainExit()
    {
        puzzlePanelExplan.SetActive(false);
    }

    public void TruthPanelExit()
    {
        GameManager.isPanel = false;
        isTruth = true;
        TruthPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void EscapePanelExit()
    {
        GameManager.isPanel = false;
        isEscape = true;
        EscapePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void VentilationPanelExit()
    {
        GameManager.isPanel = false;
        isVentilation = true;
        VentilationPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void GenaratePanelExit()
    {
        GameManager.isPanel = false;
        isGenerate = true;
        GenaratePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OpenPanelExit()
    {
        GameManager.isPanel = false;
        isOpen = true;
        OpenPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void RescuePanelExit()
    {
        GameManager.isPanel = false;
        isRescue = true;
        RescuePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void EvacuatePanelExit()
    {
        GameManager.isPanel = false;
        isEvacuate = true;
        EvacuatePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void PatrolPanelExit()
    {
        GameManager.isPanel = false;
        isPatrol = true;
        PatrolPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void InvenPanelExit()
    {
        GameManager.isPanel = false;
        InvenPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void WireGameExit()
    {
        GameManager.isPanel = false;
        WireGamePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void JigSawGameExit()
    {
        GameManager.isPanel = false;
        JigSawGamePanel.SetActive(false);

        Enemy.isEnemy = false;

        okPatrolPanel.SetActive(true);
    }

    public void ResumeBtn()
    {
        Time.timeScale = 1.0f;
        GameManager.isPanel = false;
        PausePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void CamExitBtn()
    {
        GameManager.isPanel = false;
        CamPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Paper1Exit()
    {
        GameManager.isPanel = false;
        Paper1Panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Paper2Exit()
    {
        GameManager.isPanel = false;
        Paper2Panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Paper3Exit()
    {
        GameManager.isPanel = false;
        Paper3Panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void FileDummyExit()
    {
        GameManager.isPanel = false;
        FileDummyPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void GetItemExit()
    {

        GameManager.isPanel = false;
        GetItemPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void PanExit()
    {
        GameManager.isPanel = false;
        fanPanel.SetActive(false);

        VentilationPanel.SetActive(true);
        GameManager.isPanel = true;
    }

    public void OkPatrolExit()
    {
        GameManager.isPanel = false;
        okPatrolPanel.SetActive(false);

        PatrolPanel.SetActive(true);
        GameManager.isPanel = true;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 0;
            GameManager.isPanel = true;
            PausePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            /*
            pauseNum++;
            if(pauseNum == 2)
            {
                pauseNum = 0;
            }
            if (pauseNum == 1)
            {
                Time.timeScale = 0;
                GameManager.isPanel = true;
                PausePanel.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
            else if(pauseNum == 0)
            {
                Time.timeScale = 1;
                GameManager.isPanel = false;
                PausePanel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
            */
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            camNum++;
            if(camNum == 2)
            {
                camNum = 0;
            }

            if(camNum == 1) { 
            GameManager.isPanel = true;
            CamPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            }
            else if(camNum == 0)
            {
                GameManager.isPanel = false;
                CamPanel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            invenNum++;
            if(invenNum == 2)
            {
                invenNum = 0;
            }

            if(invenNum == 1) { 
            GameManager.isPanel = true;
            InvenPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            }
            else if(invenNum == 0)
            {
                GameManager.isPanel = false;
                InvenPanel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            InvenPanelExit();
        }
    }









    public void goGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
