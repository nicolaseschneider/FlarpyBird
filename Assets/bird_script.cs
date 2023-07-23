using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{

    public float flapStr;
    public Rigidbody2D myRigidbody2D;
    public Logic_Manager logic;
    public bool lostGame = false;
    void Start() {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Manager>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && !lostGame) {
            myRigidbody2D.velocity = Vector2.up * flapStr;
        }
    }

    private void OnCollisionEnter2D(Collision2D collided) {
        lostGame = true;
        logic.gameOver();
    }
}
