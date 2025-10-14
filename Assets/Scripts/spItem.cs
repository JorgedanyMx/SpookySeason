using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spItem : MonoBehaviour
{
    public SpecialObject specialObject;
    void Start()
    {
        SetModel();
    }
    public void SetModel()
    {
        GameObject childObject = Instantiate(specialObject.model);        
        childObject.transform.SetParent(transform);
        childObject.transform.localPosition = Vector3.zero;
    }
}
