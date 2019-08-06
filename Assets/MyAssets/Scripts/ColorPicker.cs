using HoloToolkit.Examples.InteractiveElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public MeshRenderer mesh;
    public GameObject colorChild;
    public SliderGestureControl grad;
    public string fieldName;
    public Material originalColor;

    private Material novoMat;

    void OnEnable() { }
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
        mesh.gameObject.GetComponent<ToggleSelection>().ChangeEditingStatus();
        gameObject.SetActive(false);

    }
    public void SalvarCor()
    {
        mesh.material = novoMat;
        mesh.gameObject.GetComponent<ToggleSelection>().ChangeEditingStatus();
        gameObject.SetActive(false);
    }
}
