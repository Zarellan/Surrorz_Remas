using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using PrimeTween;
public class ButtonBehave : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Color colorToChange;

    [SerializeField] bool canInteract = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (canInteract)
        {
        Tween.Scale(transform,endValue:1.3f,duration:0.3f,Ease.OutSine);
        Tween.Color(GetComponent<Image>(),endValue:colorToChange,duration:0.3f,Ease.OutSine);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (canInteract)
        {
        Tween.Scale(transform,endValue:1f,duration:0.3f,Ease.OutSine);
        Tween.Color(GetComponent<Image>(),endValue:Color.white,duration:0.3f,Ease.OutSine);
        }
    }

}
