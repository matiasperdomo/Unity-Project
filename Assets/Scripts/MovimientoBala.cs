using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimiientoBala : MonoBehaviour
{
    public float speed;
    public int hp = 3;
     public float livetime;
     public float distanciadeljugador;

    // Start is called before the first frame update
    void Start()
    {
       //Debug.Log(hp);
        transform.position += Vector3.forward * distanciadeljugador; 
        Invoke("destroyBala", livetime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position += Vector3.forward * speed * Time.deltaTime;
    }

    void destroyBala()
    {
     Destroy(gameObject);
    }
    }

   // void Health(int value){
     // hp = hp + value; 

   //void Damage(int value){
      //hp = hp - value; 

    



