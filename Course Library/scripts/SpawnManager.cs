using System;
using Random=UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalprefab;
    public float spawnX=20;
    public float spawnZ=33;
    private float startdelay=2;
    private float spwninterval=1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals",startdelay,spwninterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
           SpawnAnimals();
        }
        
    }
    void SpawnAnimals(){
                int indexanimal=Random.Range(0,animalprefab.Length);
                Vector3 locationspawn=new Vector3(Random.Range(spawnX,-spawnX),0,Random.Range(-13,spawnZ));
                Instantiate(animalprefab[indexanimal],locationspawn,animalprefab[indexanimal].transform.rotation);
    }
}
