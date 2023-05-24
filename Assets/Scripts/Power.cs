using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : Pickup
{
    public PlayerController playerController;
    public Sprite powered;
    public Sprite normal;

    public override void Activate()
    {

    }

    IEnumerator StartPower()
    {
        playerController.isPowered = true;
        playerController.playerSR.sprite = powered;
        yield return new WaitForSeconds(5f);
        playerController.isPowered = false;
        playerController.playerSR.sprite = normal;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Activate();
        StartCoroutine(StartPower());

    }
}
