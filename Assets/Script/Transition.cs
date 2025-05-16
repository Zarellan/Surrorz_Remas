using System.Collections;
using System.Collections.Generic;
using PrimeTween;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Transition : MonoBehaviour
{
    public static Transition instance;
    [SerializeField] GameObject black;
    bool canInteract = true;
    // Start is called before the first frame update
    void Start()
    {
        

        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeScene(string sceneToChange)
    {
        canInteract = false;
        Tween.UIAnchoredPositionX(black.GetComponent<RectTransform>(),0,0.4f,Ease.OutCirc);
        StartCoroutine(Timer.timer(0.5f,()=>{
            SceneManager.LoadScene(sceneToChange);
            Tween.UIAnchoredPositionX(black.GetComponent<RectTransform>(),-1920,0.4f,Ease.OutCirc).OnComplete(()=>black.GetComponent<RectTransform>().position = new Vector2(0,1920));
        }));
    }
}
