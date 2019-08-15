using HoloToolkit.Examples.InteractiveElements;
using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowChanges : MonoBehaviour
{
    public GameObject parentParts;

    public TwoHandManipulatable manipulate;
    public GameObject axis;
    public InteractiveToggle toggleMove;
    public InteractiveToggle toggleRotate;
    public InteractiveToggle toggleScale;

    void Start()
    {
        manipulate.ManipulationMode = ManipulationMode.None;
        manipulate.RotationConstraint = AxisConstraint.None;
    }
    public void AllowChange(bool status)
    {
        manipulate.enabled = !status;//nao posso mexer nada
        for (int i = 0; i < parentParts.transform.childCount; i++)//ativo ou desativo a cor pra selecionar
            parentParts.transform.GetChild(i).GetComponent<ChangeColor>().enabled = status;
    }

    public void ChangeInteractions()
    {
        if ( toggleRotate.IsSelected)
            SetRotationConstraint();
        else
            axis.SetActive(false);


        manipulate.ManipulationMode = (ManipulationMode)
            ((toggleMove.IsSelected ? 1 << 0 : 0) |
            (toggleScale.IsSelected ? 1 << 1 : 0) |
            (toggleRotate.IsSelected ? 1 << 2 : 0));
    }

    private void SetRotationConstraint()
    {
        axis.SetActive(true);
        var rotar = axis.GetComponent<InteractiveSet>().SelectedIndices.ToArray();
        manipulate.RotationConstraint = ((AxisConstraint)rotar[0]);
    }
}
