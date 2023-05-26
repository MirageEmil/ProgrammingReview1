using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : Pickup
{

    public override void Activate()
    {
        gameManager.EarnPoints();
    }

}
