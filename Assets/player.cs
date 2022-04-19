using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{



   float rotateSpeed=50;
void Start()
    {          
               
               Debug.Log("Hello from Start()");
    }


    // Update is called once per frame
    void Update()
    {           
                         if(Input.GetKey(KeyCode.W))
                       {
                              this.gameObject.transform.position+=transform.forward;
                               
                      }

                               if(Input.GetKey(KeyCode.S))
                       {
                              this.gameObject.transform.position-=transform.forward;
                               
                      }
                       
                          if(Input.GetKey(KeyCode.A))
                      {
                          transform.Rotate(0,-rotateSpeed*Time.deltaTime,0,0);
                      }  
        
                         else if(Input.GetKey(KeyCode.D))
                      {
                          transform.Rotate(0,rotateSpeed*Time.deltaTime,0,0);
                       }                  
    }
}
