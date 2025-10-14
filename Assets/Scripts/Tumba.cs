using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumba : MonoBehaviour
{
    public SpecialObject spItem;
    public GameObject refObj;
    public void SetSpecialItem(SpecialObject specialItem)
    {
        if (refObj==null) {
            Debug.LogError("Falta referencia del objecto");
                }
        spItem = specialItem;
        GameObject childObject = Instantiate(spItem.model);
        childObject.transform.SetParent(transform);
        childObject.transform.localPosition = refObj.transform.localPosition;
    }
}
