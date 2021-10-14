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

    void Start()
    {
        //Instantiate(enemyPrefab, transform);
        //Instantiate(enemyPrefab, transform.position, enemyPrefab.transform.rotation);
        //Debug.Log(Quaternion.identity);
        //Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        //int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        //Instantiate(enemyPrefabs[enemyIndex], transform.position, enemyPrefabs[enemyIndex].transform.rotation);
        InvokeRepeating("Disparo", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Disparo()
    {
        int disparoIndex = Random.Range(0, disparoPrefabs.Length);
        Instantiate(disparoPrefabs[disparoIndex], transform.position, disparoPrefabs[disparoIndex].transform.rotation);
    }

}