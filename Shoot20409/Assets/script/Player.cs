using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float moveSpeed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
    void MoveControl() {
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(moveX, moveY, 0);
        //print(Input.GetAxis("Horizontal"));
    }
	
	// Update is called once per frame
	void Update () {
        MoveControl();
	}
}
