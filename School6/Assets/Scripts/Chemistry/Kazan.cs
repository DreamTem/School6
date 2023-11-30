using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kazan : MonoBehaviour, IDropHandler
{
    public ChemistryMainGameplay levelController;
    public int dragsCount = 0;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
    public void AddDrag()
    {
        if(dragsCount < 4)
        {
            dragsCount += 1;
        }
        else
        {
            levelController.PlayGosling();
        }
    }
}
