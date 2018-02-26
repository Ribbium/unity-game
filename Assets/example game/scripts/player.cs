using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    public string logText = "hello faggots";
    public float speed = 2;
    // Use this for initialization
    void Start () {


        Debug.Log(logText);
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        GetComponent<Rigidbody2D>().velocity = Vector2.right;

    }
	
	// Update is called once per frame
	void Update ()
    {
        

    }
}
