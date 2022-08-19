using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float startDelay = 1.0f;
    private float spawnInterval = 2f;
   
    void Start()
    {
        
         InvokeRepeating("RandomFeatures", startDelay, spawnInterval);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 20.0f * Time.deltaTime, 30.0f * Time.deltaTime);  
    }

    void RandomFeatures(){

        Material material = Renderer.material;
         
        material.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 
                                    Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f));

        transform.position = new Vector3(Random.Range(-5.0f,5.0f), Random.Range(-3.0f,3.0f), 
                                        Random.Range(-1.0f,1.0f));
        transform.localScale = Vector3.one * Random.Range(0.5f,5.0f);


    }
}
