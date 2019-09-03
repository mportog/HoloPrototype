using HoloToolkit.Examples.InteractiveElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssociateGoCheck : MonoBehaviour
{
    public InteractiveToggle toggle;

    public void ActiveState()
    {
        toggle.HasSelection = true;
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<MeshCollider>().enabled = false;
    }

    public void InactiveState()
    {
        toggle.HasSelection = false;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<MeshCollider>().enabled = false;
    }
}
