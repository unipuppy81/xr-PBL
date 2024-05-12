using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class MySceneManager : MonoBehaviour
{
    public static MySceneManager Instance
    {
        get
        {
            return instance;
        }
    }
    private static MySceneManager instance;

    void Start()
    {
        if (instance != null)
        {
            DestroyImmediate(this.gameObject);
            return;
        }
        instance = this;

        //DontDestroyOnLoad(gameObject);

    }

    private void OnDestroy()
    {
        //SceneManager.sceneLoaded -= OnSceneLoaded; // 이벤트에서 제거
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Fade_img.DOFade(0, fadeDuration)
        .OnComplete(() => {
            Fade_img.blocksRaycasts = false;
        });
    }
    public CanvasGroup Fade_img;
    float fadeDuration = 1.5F; //암전되는 시간

    
    public void ChangeScene(string sceneName)
    { /// 외부에서 전환할 씬 이름 받기 ///
        Fade_img.DOFade(1, fadeDuration)
        .OnStart(() => {
            Fade_img.blocksRaycasts = true;
        })
        .OnComplete(() => {
            SceneManager.LoadScene("MainScene");
            StartCoroutine("LoadScene", sceneName); /// 씬 로드 코루틴 실행 ///
    });
    }
    
    IEnumerator LoadScene(string sceneName)
    {

        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);

        float past_time = 0;
        float percentage = 0;

        
        while (!(async.isDone))
        {
            yield return null;
            past_time += Time.deltaTime;
        }
        
    }
    
}
