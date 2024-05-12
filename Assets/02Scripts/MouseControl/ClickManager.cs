using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    private Image image;

    public Sprite defaultCursorTexture; // �⺻ Ŀ�� �̹���
    public Sprite clickCursorTexture; // Ŭ�� �� ������ Ŀ�� �̹���

    void Start()
    {

        image = GetComponent<Image>();
    }

    void Update()
    {
        // ���콺 ���� ��ư Ŭ�� ����
        if (Input.GetMouseButtonDown(0))
        {
            image.sprite = clickCursorTexture;
            
        }
        // ���콺 ���� ��ư ���� ����
        else if (Input.GetMouseButtonUp(0))
        {


            // Ŀ�� �̹����� ������� ����
            image.sprite = defaultCursorTexture;
        }
    }
}
