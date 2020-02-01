using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPortal : MonoBehaviour
{
    private HaveGear dManGear;
    private HaveClock dManClock;
    public bool portal = false;

    // Start is called before the first frame update
    void Start()
    {
        dManGear = FindObjectOfType<HaveGear>();
        dManClock = FindObjectOfType<HaveClock>();
        GetComponent<BoxCollider2D> ().enabled = false;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f); //Por transparente
    }

    // Update is called once per frame
    void Update()
    {
        if (dManClock.DestroyedClock && dManGear.DestroyedGear && !portal)
        {
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            portal = true;
        }
    }
}
