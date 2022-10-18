using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuHareket : MonoBehaviour
{
    public float akisHizi = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * akisHizi * Time.deltaTime);
        if (transform.position.z >= 100)
        {
            transform.position = new Vector3(0f, 1.5f, 0f);
        }
    }
}
