using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <-23){
            Destroy(gameObject);
        }else if(transform.position.x >24){
            Destroy(gameObject);
        }
        
    }
}
