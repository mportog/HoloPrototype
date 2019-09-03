using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class InitialSetup : MonoBehaviour
{
    public GameObject imageTarget;
    public void Manual()
    {
        imageTarget.GetComponent<DefaultTrackableEventHandler>().
            OnTrackableStateChanged(TrackableBehaviour.Status.UNKNOWN, TrackableBehaviour.Status.TRACKED);
        imageTarget.GetComponent<MeshRenderer>().enabled = false;
    }



}
