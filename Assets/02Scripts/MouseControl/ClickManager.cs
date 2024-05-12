using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    private Image image;

    public Sprite defaultCursorTexture; // 기본 커서 이미지
    public Sprite clickCursorTexture; // 클릭 시 보여질 커서 이미지

    void Start()
    {

        image = GetComponent<Image>();
    }

    void Update()
    {
        // 마우스 왼쪽 버튼 클릭 감지
        if (Input.GetMouseButtonDown(0))
        {
            image.sprite = clickCursorTexture;
            
        }
        // 마우스 왼쪽 버튼 떼기 감지
        else if (Input.GetMouseButtonUp(0))
        {


            // 커서 이미지를 원래대로 돌림
            image.sprite = defaultCursorTexture;
        }
    }
}
