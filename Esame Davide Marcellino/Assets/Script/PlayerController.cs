using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour {
    public Camera rigidB;
    public int speed = 10;
    public int coinsCollected = 0;
    // Use this for initialization
    void Start () {
        rigidB = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update () {
        if(Input.GetKey("w")){
            rigidB.AddForce(Vector3.forward * speed);
        }
        if(Input.GetKey("s")){
            rigidB.AddForce(Vector3.back * speed);
        }
        if(Input.GetKey("d")){
            rigidB.AddForce(Vector3.right *speed);
        }
        if(Input.GetKey("a")){
            rigidB.AddForce(Vector3.left *speed);
        }
    }

}
