using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    public string logText = "hello faggots";
    public float speed = 2;
    public float health = 10;
    // Use this for initialization
    void Start () {


        Debug.Log(logText);
        damage(3);
       

    }
	
	// Update is called once per frame
	void Update ()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        GetComponent<Rigidbody2D>().velocity = Vector2.right;

    }
 public void damage(float damage)
    {

        health = health - damage; 




    }
}
