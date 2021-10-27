using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderController : MonoBehaviour
{
    public float speedEnemy = 5.0f;
    public float liveEnemy = 7.0f;
    //bool isForward = true;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("SpaceShip");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        LookAtPlayer();
        MoveTowards();
        
    }
    private void MoveEnemy(Vector3 direction)
    {
        transform.Translate(speedEnemy * Time.deltaTime * direction);
    }

    private void MoveTowards()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        transform.position += speedEnemy * direction * Time.deltaTime;
    }

    private void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }

}
