using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHareket : MonoBehaviour
{
    public float hareketHiz = 10f;
    public float donusHiz = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * hareketHiz * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * hareketHiz * Time.deltaTime);
        }

        

        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * donusHiz * Time.deltaTime);
    }
}
