using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGift : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("BadGift");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Hallo Wichtel " + collision.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}