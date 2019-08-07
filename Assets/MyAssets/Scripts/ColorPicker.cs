using HoloToolkit.Examples.InteractiveElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public MeshRenderer mesh;
    public GameObject colorChild;
    public SliderGestureControl grad;
    public TextMesh fieldName;
    public Material originalColor;

    private Material novoMat;

    void OnEnable()
    {
        fieldName.text = "";
        originalColor = null;
        mesh = null;
    }
    public void SelectedMaterial(int novo)
    {
        novoMat = colorChild.transform.GetChild(novo).GetComponent<MeshRenderer>().material;
        mesh.material = novoMat;
    }
    public void ChangeAlpha()
    {
        mesh.material.color = new Color(novoMat.color.r, novoMat.color.g, novoMat.color.b, grad.SliderValue);
    }
    public void ResetarCor()
    {
        novoMat = originalColor;
        mesh.material = originalColor;
        gameObject.SetActive(false);

    }
    public void SalvarCor()
    {
        mesh.material = novoMat;
        gameObject.SetActive(false);
    }
}
