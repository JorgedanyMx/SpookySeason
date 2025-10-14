using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbasManager : MonoBehaviour
{

    public SpecialObject[] spArray;
    [SerializeField] GameObject[] tumbasArr;
    // Start is called before the first frame update
    void Start()
    {
        tumbasArr = GameObject.FindGameObjectsWithTag("TumbaInteract");
        if (tumbasArr.Length >= spArray.Length)
        {
            SetRandomItemToTomb();
        }
        else
        {
            Debug.LogError("Agrega más tumbas con Tag TumbaInteract");
        }
    }
    void SetRandomItemToTomb()
    {
        // Crear una lista temporal para mezclar los valores de B
        List<SpecialObject> valoresDisponibles = new List<SpecialObject>(spArray);

        // Mezclar la lista
        for (int i = 0; i < valoresDisponibles.Count; i++)
        {
            int j = Random.Range(i, valoresDisponibles.Count);
            (valoresDisponibles[i], valoresDisponibles[j]) = (valoresDisponibles[j], valoresDisponibles[i]);
        }

        // Asignar los valores únicos a A
        for (int i = 0; i < valoresDisponibles.Count; i++)
        {   // Llama al componente de Tumba, luego asigna su item
            if (valoresDisponibles[i] != null)
            {
                Debug.Log("Hola");
                tumbasArr[i].GetComponent<Tumba>().SetSpecialItem(valoresDisponibles[i]);
                
            }
        }
    }

}
