using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

  void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("the jews are to blame");

        player mario = collision.collider.GetComponent<player>();
        mario.damage(2);
    }
    
}
