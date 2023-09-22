using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class pTwoMove : MonoBehaviour
{
    float MoveSpeed = 5.0f;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.W)) // gets input once per press
        // {
        //     gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * MoveSpeed * Time.deltaTime; // applies force 
        // }
        if (Input.GetKey(KeyCode.UpArrow)) // gets input entire time key is pressed
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * MoveSpeed;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.down * MoveSpeed; // applies force 
        }
        if (Input.GetKey(KeyCode.DownArrow)) // gets input 
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.back * MoveSpeed;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.down * MoveSpeed;    // applies force 
        }
        if (Input.GetKey(KeyCode.RightArrow)) // gets input 
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * MoveSpeed;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.down * MoveSpeed;   // applies force 
        }
        if (Input.GetKey(KeyCode.LeftArrow)) // gets input 
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.left * MoveSpeed;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.down * MoveSpeed;    // applies force 
        }
        void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("PickUp") && count <= 5)
            {

                other.gameObject.SetActive(false);
                count = count + 1;
            }
            else if (count == 6)
            {
                ScoreTracker.ScoreTickerPtwo(count);
                count = count + 1;
            }
        }
    }
}
