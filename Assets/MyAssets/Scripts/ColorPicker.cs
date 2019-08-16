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

    public InteractiveToggle[] Axis;
    public InteractiveToggle[] Toggles;
    public InteractiveToggle toggleColor;
    public GameObject checkboxSet;
    public AllowChanges permission;

    private Material novoMat;

    void OnEnable()
    {
        permission.AllowChange(false);

        if (checkboxSet.activeInHierarchy)
            foreach (var toggles in Axis)
            {
                toggles.AllowDeselect = false;
                toggles.AllowSelection = false;
            }

        foreach (var toggles in Toggles)
        {
            toggles.AllowDeselect = false;
            toggles.AllowSelection = false;
        }

        fieldName.text = "";
        originalColor = null;
        mesh = null;
    }
    private void OnDisable()
    {
        if (checkboxSet.activeInHierarchy)
            foreach (var toggles in Axis)
            {
                toggles.AllowDeselect = true;
                toggles.AllowSelection = true;
            }

        foreach (var toggles in Toggles)
        {
            toggles.AllowDeselect = true;
            toggles.AllowSelection = true;
        }
        toggleColor.HasSelection = false;
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
        mesh.material.color = new Color(novoMat.color.r, novoMat.color.g, novoMat.color.b, grad.SliderValue);
        gameObject.SetActive(false);
    }
}
