using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int countCollisions = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Cat")
        {
            countCollisions--;
        }
        else if (collision.name == "Bird")
        {
            countCollisions--;
        }
        else if (collision.name == "Nut")
        {
            Debug.Log("in if in Nut + 1 ");
            countCollisions++;
        }
        else if (collision.name == "Nest")
        {
            Debug.Log("in if in Nest + 1 ");
            countCollisions++;
        }

        Debug.Log("count Collisions " + countCollisions);
        Debug.Log("In Player, collide with " + collision);
    }
}
