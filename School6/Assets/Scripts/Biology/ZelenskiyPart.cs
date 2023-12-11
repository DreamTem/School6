using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZelenskiyPart : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Image image;
    public RectTransform anchor;
    public GameObject imageToDisable;
    public Zelenskiy gameController;

    private bool canBeDragged = true;
    // Start is called before the first frame update
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (canBeDragged == false) return;
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (canBeDragged == false) return;
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (canBeDragged == false) return;
        image.raycastTarget = true;
        if (rectTransform.anchoredPosition == anchor.anchoredPosition)
        {
            canBeDragged = false;
            imageToDisable.SetActive(false);
            gameController.AddPart();
        }
    }
}
