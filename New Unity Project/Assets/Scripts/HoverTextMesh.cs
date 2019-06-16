using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class HoverTextMesh : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI textMesh;
    public void OnPointerEnter(PointerEventData eventData)
    {
        //textMesh.enabled = true;
        textMesh.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //textMesh.enabled = false;
        textMesh.gameObject.SetActive(false);
    }
}
