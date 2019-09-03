using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPainelManager : MonoBehaviour
{
    public GameObject colorPanel;//painel de selecao de cor a ser mudado de posição
    //public float fixedYPos;//altura em que o painel terá, fixo, acima do holograma

    void Start() { }
    void Update() { }
    public void PositionPanel(string label, int indice, MeshRenderer peca, Material originalColor)
    {

        colorPanel.SetActive(true);

        //colorPanel.transform.localPosition = new Vector3(transform.GetChild(indice).position.x, fixedYPos, transform.GetChild(indice).position.z);
        colorPanel.transform.position = transform.GetChild(indice).position;

        colorPanel.GetComponent<ColorPicker>().mesh = peca;
        colorPanel.GetComponent<ColorPicker>().originalColor = originalColor;
        colorPanel.GetComponent<ColorPicker>().fieldName.text = label;
    }
}
