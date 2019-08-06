using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSelection : MonoBehaviour, IInputClickHandler, IFocusable
{
    private bool menuIsOpen;
    private bool editing;

    public GameObject select;
    public GameObject tooltip;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (!editing)
        {
            menuIsOpen = !menuIsOpen;
            select.SetActive(menuIsOpen);
        }
    }
    void OnDisable()
    {
        select.SetActive(false);
    }
    void OnEnable()
    {
        menuIsOpen = false;
        editing = false;
        select.SetActive(menuIsOpen);
    }
    public void OnFocusEnter()
    {
        if (!editing && !menuIsOpen)
            tooltip.SetActive(true);
    }
    public void OnFocusExit()
    {
        if (!editing && !menuIsOpen)
            tooltip.SetActive(false);
    }
    public void ChangeEditingStatus()
    {
        this.editing = !editing;
        tooltip.SetActive(false);
    }
}
