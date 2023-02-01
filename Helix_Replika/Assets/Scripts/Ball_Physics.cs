using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Physics : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody BallRB;
    public float jumpForce;
    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {

        

        string MaterialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Material:" +  MaterialName); 


        if ( MaterialName == "Safe_Color (Instance)"){
            // Getting Point
            BallRB.AddForce(Vector3.up * jumpForce);

        }
        else if( MaterialName == "Unsafe_Color (Instance)"){
            // Dead

            Debug.Log("Oyun bitti olm");
           
            gm.Restart();


        }
        else{

            // Finish - next level



        }
        

    }

}
 