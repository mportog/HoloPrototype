using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToOpen : MonoBehaviour, IInputClickHandler
{
    public GameObject obj;//tooltip e obj
    public GameObject painel;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        obj.GetComponent<ToggleSelection>().ChangeEditingStatus();
        painel.SetActive(true);
        gameObject.SetActive(false);
    }

    void Start() { }
    void Update() { }
}
