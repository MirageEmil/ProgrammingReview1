using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : Pickup
{

    public override void Activate()
    {
        gameManager.EarnPoints();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Activate();
        }
    }
}
