using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLight : MonoBehaviour
{
    public GameObject[] Light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9)) 
        {
           Light[0].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F10))
        {
            Light[0].SetActive(true);
        }
    }
}
