using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalinput;
    public float speed=10.0f;
    public GameObject projectileprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -14){
            transform.position=new Vector3(transform.position.x,transform.position.y,-14);
        }
          if(transform.position.z > 33){
            transform.position=new Vector3(transform.position.x,transform.position.y,33);
        }
     
        horizontalinput=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);
        
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectileprefab,transform.position,projectileprefab.transform.rotation);
        }
    }
}
