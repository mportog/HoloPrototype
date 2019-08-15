using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IHoldHandler, IFocusable
{
    public int childNumber;
    public PositionPainelManager posi;

    private Material originalMaterial;
    private Color originalColor;

    void OnEnable()
    {
        originalMaterial = GetComponent<MeshRenderer>().material;
        originalColor = GetComponent<MeshRenderer>().material.color;
    }
    void Update() { }
    public void OnFocusEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
    public void OnFocusExit()
    {
        GetComponent<MeshRenderer>().material.color = originalColor;
    }
    public void OnHoldStarted(HoldEventData eventData) { }
    public void OnHoldCompleted(HoldEventData eventData)
    {
        originalMaterial.color = originalColor;      
        posi.PositionPanel(gameObject.name, childNumber, GetComponent<MeshRenderer>(), originalMaterial);
    }
    public void OnHoldCanceled(HoldEventData eventData) { }
}
