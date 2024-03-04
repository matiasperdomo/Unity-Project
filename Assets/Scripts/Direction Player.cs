using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionPlayer : MonoBehaviour
{
    public GameObject Move;
    public GameObject Munition;
    public float speed;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //direccion del jugador WASD
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }

    }
    private void MovePlayer(Vector3 Direction)
    {
        transform.Translate(Direction * speed * Time.deltaTime);
    }
    private void shoot()
    {
        Debug.Log("shoot");
        Instantiate(Munition, transform.position, Munition.transform.rotation);

    }
   









}

