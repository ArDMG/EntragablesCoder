using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
     
    public string namePlayer = "Space Ship";
    public int life = 5;
    public int healLife;
    public int damageLife;
    public float Speed;
    private float initialSpeed = 0f;
    public Vector3 scale;
    public Vector3 position;
   
    // Start is called before the first frame update
    void Start()
    { 
        Debug.Log("Ship Starter Life: " + life);
        Debug.Log("Ship Lifes Added: " + healLife);
        Debug.Log("Ship Lifes Reduced: " + damageLife);
        Debug.Log("Ship Total Lifes: " + (life + healLife - damageLife));

    }
    // Update is called once per frame
    void Update()
        {
         Debug.Log("Ship Move");
         transform.position += new Vector3(0f, 0f, 0.01f) * Speed;
         Debug.Log("Ship Position: " + transform.position);
        }
    void MovePlayer()
    {
        //Move
        Debug.Log("Ship Start");
        transform.localScale = scale;
        transform.position = position;
        initialSpeed = Speed;
    }
    void HealPlayer()
    {
        //+Life
        life = life + healLife;
        Debug.Assert(life > 0);
        //Debug.Log("Ship Lifes Added: " + healLife);
        // Debug.Log("Ship Total Lifes: " + life);
    }
    void DamagePlayer()
    {
         //-Life
         life = life - damageLife;
         Debug.Assert(life > 0);
         //Debug.Log("Ship Lifes Reduced: " + damageLife);
         //Debug.Log("Ship Total Lifes: " + life);
    }
}

