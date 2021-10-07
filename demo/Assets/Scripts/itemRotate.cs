using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.N)){
            transform.rotation *= Quaternion.Euler(Vector3.forward * 1);
         }if(Input.GetKey(KeyCode.M)){
            transform.rotation *= Quaternion.Euler(Vector3.forward * -1);
         }

         
        bool isLeftButtonDown = Input.GetMouseButtonDown (0); 
        if(isLeftButtonDown) print(1);
         
    }
}
