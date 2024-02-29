using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 3f;
    public int hp = 3;

    public string namePlayer = "Mr. Cube";


    // Start is called before the first frame update
    void Start()
    {
        Damage(30);
        Health(100);
        Debug.Log(hp);
        transform.position += Vector3.forward * 2f; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position += Vector3.forward * speed * Time.deltaTime;
    }

    void Damage(int value){
      hp = hp - value; 

    }

    void Health(int value){
      hp = hp + value; 

    }



}