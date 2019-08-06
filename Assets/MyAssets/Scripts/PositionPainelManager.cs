using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPainelManager : MonoBehaviour
{
    public Transform[] posi;
    public GameObject colorPanel;
    public float fixedYPos;

    void Start() { }
    void Update() { }
    public void PositionPanel(string label, int indice, MeshRenderer peca)
    {
        colorPanel.SetActive(true);
        colorPanel.transform.position = new Vector3(posi[indice].position.x, fixedYPos, posi[indice].position.z);
        colorPanel.GetComponent<ColorPicker>().mesh = peca;
    }
}
