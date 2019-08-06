using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IHoldHandler, IFocusable
{
    public ColorPicker picker;
    private Material originalColor;

    void OnEnable()
    {
        originalColor.color = GetComponent<MeshRenderer>().material.color;
    }
    void Update() { }
    public void ChangeItem()
    {
        picker.mesh = GetComponent<MeshRenderer>();
        picker.originalColor = originalColor;
        picker.fieldName = gameObject.name;
    }
    public void OnFocusEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
    public void OnFocusExit()
    {
        GetComponent<MeshRenderer>().material.color = originalColor.color;
    }
    public void OnHoldStarted(HoldEventData eventData) { }
    public void OnHoldCompleted(HoldEventData eventData)
    {
        ChangeItem();
    }
    public void OnHoldCanceled(HoldEventData eventData) { }
}
