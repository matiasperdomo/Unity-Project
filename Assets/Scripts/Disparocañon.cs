using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparocanon : MonoBehaviour
{
    public GameObject velocidadbala;
    public float Timebala;
    public float Intervalodespawneo;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Configbala",Timebala,Intervalodespawneo);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void Configbala()
    {
        Instantiate(velocidadbala, transform);
    }
}
