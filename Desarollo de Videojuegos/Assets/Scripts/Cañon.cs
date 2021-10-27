using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject enemyPrefab;
    public GameObject[] disparoPrefabs;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    public Vector3 scale;
  
    void Start()
    {
        InvokeRepeating("Disparo", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Disparo();
        }
        
    }

    void Disparo()
    {
        int disparoIndex = Random.Range(0, disparoPrefabs.Length);
        Instantiate(disparoPrefabs[disparoIndex], transform.position, disparoPrefabs[disparoIndex].transform.rotation);
    }
 
}