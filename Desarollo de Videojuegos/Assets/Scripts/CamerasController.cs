using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    public GameObject[] Cams;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Cams[0].SetActive(true);
            Cams[1].SetActive(false);
            Cams[2].SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cams[0].SetActive(false);
            Cams[1].SetActive(true);
            Cams[2].SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            Cams[0].SetActive(false);
            Cams[1].SetActive(false);
            Cams[2].SetActive(true);
        }
    }
}
