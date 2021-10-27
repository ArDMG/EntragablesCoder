using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersGenerator : MonoBehaviour
{

    //enum Difficulties { Easy, Normal, Hard };
    enum Difficulties { Easy = 1, Normal, Hard };

    [SerializeField] private GameObject[] invaderPrefabs;
  
    [SerializeField] private float startDelay = 2;
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private Difficulties difficulty;

    void Start()
    {
        Debug.Log(difficulty);
        Debug.Log(((int)difficulty));
     
        switch (difficulty)
        {
            case Difficulties.Easy:
                Debug.Log("FACIL");
                InvokeRepeating("SpawnInvaders", (startDelay + 3f), (spawnInterval + 3f));
                break;
            case Difficulties.Normal:
                Debug.Log("NORMAL");
                InvokeRepeating("SpawnInvaders", startDelay, spawnInterval);
                break;
            case Difficulties.Hard:
                Debug.Log("DIFICIL");
                InvokeRepeating("SpawnInvaders", (startDelay -1f), (spawnInterval -1f));
                break;
            default:
                Debug.Log("<color=#FF0000>ERROR AL ELEGIR NIVEL</color>");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnInvaders()
    {
        int enemyIndex = Random.Range(0, invaderPrefabs.Length);
        Instantiate(invaderPrefabs[enemyIndex], transform.position, invaderPrefabs[enemyIndex].transform.rotation);
    }

}
