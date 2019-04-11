using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public List<GameObject> selectedUnits;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject unit in GameObject.FindGameObjectsWithTag("Unit"))
        {
            selectedUnits.Add(unit);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            foreach(GameObject unit in selectedUnits)
            {
                

            }
        }
        
    }
}
