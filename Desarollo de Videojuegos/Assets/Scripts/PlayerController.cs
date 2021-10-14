using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lifePlayer = 3;
    public string namePlayer = "Space Invader";
    private float speedPlayer = 100.0f;
    public Vector3 scale;
    public Vector3 position;
    public float initialSpeedPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Invader Start");
        Debug.Log("Invader Start Position: " + transform.position.x);
        transform.localScale = scale;
        transform.position = position;
        speedPlayer = initialSpeedPlayer;
        Debug.Assert(lifePlayer > 0);
        Debug.Log("Invader Lifes: " + lifePlayer) ;
       // Debug.Break();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Invader Move");
        transform.position += new Vector3(0f, 0.1f, 0f) * initialSpeedPlayer;
        Debug.Log("Invader Position: " + transform.position);

    }
}
