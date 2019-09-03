using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PainelManager : MonoBehaviour
{
    public GameObject ImageTarget;

    public void ScanQr()
    {
        CameraDevice.Instance.Start();
    }
    public void Manual()
    {
        ImageTarget.SetActive(true);
        ImageTarget.GetComponent<MeshRenderer>().enabled = false;
        CameraDevice.Instance.Stop();
    }
}
