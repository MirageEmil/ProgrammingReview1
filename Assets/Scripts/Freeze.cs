using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : Pickup
{
    public EnemyController enemyController;
    public GameObject[] snakes;

    public override void Activate()
    {
        Freezer();
    }

    public void Freezer()
    {
        snakes = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(GameObject snake in snakes)
        {
            snake.GetComponent<EnemyController>().speed = 0;
        }

        StartCoroutine(StopItNow());

    }

    IEnumerator StopItNow()
    {
        yield return new WaitForSeconds(3f);

        foreach (GameObject snake in snakes)
        {
            snake.GetComponent<EnemyController>().speed = 10;
        }

    }
}
