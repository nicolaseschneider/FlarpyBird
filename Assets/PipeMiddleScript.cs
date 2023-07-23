using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Logic_Manager logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 3) {
            logic.addScore();
        }
    }
}
