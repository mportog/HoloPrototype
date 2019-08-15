using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionButton : MonoBehaviour, IInputClickHandler {
    public GameObject nextGO;
    public GameObject thisGO;


    public void OnInputClicked(InputClickedEventData eventData)
    {
        nextGO.SetActive(true);
        thisGO.SetActive(false);
    }
}
