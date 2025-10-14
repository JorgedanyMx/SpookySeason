using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SpecialObject", menuName = "SpecialObject/Item")]

public class SpecialObject : ScriptableObject
{
    public string nameObject;
    public Sprite image;
    public string primerMensaje;
    public string ultimoMensaje;
    public GameObject model;
    SpecialObject nextObject;
}
