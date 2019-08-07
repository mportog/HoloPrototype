using HoloToolkit.Examples.InteractiveElements;
using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowManipulationChange : MonoBehaviour
{
    public TwoHandManipulatable manipulate;
    public GameObject axis;
    public InteractiveToggle move;
    public InteractiveToggle rotate;
    public InteractiveToggle scale;
    private void ChangeInteractions()
    {
        var test = move.IsSelected ? 1 << 0 : 0;
        var test2 = rotate.IsSelected ? 1 << 2 : 0;
        var test3 = scale.IsSelected ? 1 << 1 : 0;
        var finalTest = test | test3 | test2;
        manipulate.ManipulationMode = (ManipulationMode)finalTest;
        Debug.Log(manipulate.ManipulationMode);
    }
}
