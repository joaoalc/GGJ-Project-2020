using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveKey : MonoBehaviour
{
    private GetKey dMan;

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<GetKey>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (dMan.HaveKey)
        {
            Destroy(gameObject);
        }
 
    }

}
