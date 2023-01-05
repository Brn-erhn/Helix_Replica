using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Physics : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody BallRB;
    public float jumpForce;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {

        BallRB.AddForce(Vector3.up * jumpForce);

        string MaterialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Material:" +  MaterialName); 


        if ( MaterialName == "Safe_Color (Instance)"){
            // Getting Point


        }
        else if( MaterialName == "Unsafe_Color (Instance)"){
            // Dead

            Debug.Log("Oyun bitti olm");


        }
        else{

            // Finish - next level



        }
        

    }

}
 