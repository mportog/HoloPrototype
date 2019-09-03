using HoloToolkit.Examples.InteractiveElements;
using HoloToolkit.Unity;
using HoloToolkit.Unity.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PrototypePartsTree : MonoBehaviour
{

    public GameObject prototype;
    public GameObject checkbox;
    private int childNumber;
    public Transform center;

    public GameObject[] checkboxesTree;

    private void OnEnable()
    {
        childNumber = prototype.transform.childCount;
        checkboxesTree = new GameObject[childNumber];

        for (int i = 0; i < childNumber; i++)
        {
            var item = prototype.transform.GetChild(i).gameObject;
            GameObject check = Instantiate(checkbox, center);
            check.transform.localScale = new Vector3(1f, 1.5f, 1f);
            check.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);

            check.GetComponent<LabelTheme>().Default = item.gameObject.name;
            check.GetComponent<LabelTheme>().Selected = item.gameObject.name;

            var go = item.EnsureComponent<AssociateGoCheck>();
            go.toggle = check.GetComponent<InteractiveToggle>();

            check.GetComponent<InteractiveToggle>().OnSelection.AddListener(go.ActiveState);
            check.GetComponent<InteractiveToggle>().OnDeselection.AddListener(go.InactiveState);

                if (item.activeInHierarchy)
                check.GetComponent<InteractiveToggle>().HasSelection = true;
            else
                check.GetComponent<InteractiveToggle>().HasSelection = false;

            checkboxesTree[i] = check;
        }

        var organizar = center.gameObject.GetComponent<ObjectCollection>();
        organizar.Rows = childNumber;
        organizar.UpdateCollection();
    }
}
