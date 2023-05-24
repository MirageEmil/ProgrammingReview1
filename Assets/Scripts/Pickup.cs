using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public SpriteRenderer spriteR;
    public CircleCollider2D circleCollider;
    public GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }

    public virtual void Activate()
    {

    }

    IEnumerator DelayedDestroy()
    {
        spriteR = null;
        circleCollider = null;
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Activate();
        StartCoroutine(DelayedDestroy());

    }
}
