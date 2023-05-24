using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            Vector3 direction = player.position - transform.position;

            direction.Normalize();

            Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;

            transform.position = newPosition;
        }
    }
}
