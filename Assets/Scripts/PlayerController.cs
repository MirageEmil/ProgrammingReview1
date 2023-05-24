using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed = 10f;

    public bool isPowered = false;

    public SpriteRenderer playerSR;
    public Sprite dead;
    public Sprite normal;

    public GameManager gameManager;
    public Power power;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime * verticalInput);
    }

    public void ChangeSprite(Sprite sprite)
    {
        if(playerSR != null)
        {
            playerSR.sprite = sprite;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && power == null)
        {
            StartCoroutine(HitTaken());

        }
        else if (collision.gameObject.CompareTag("Enemy") && power != null)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator HitTaken()
    {
        moveSpeed = 0f;
        ChangeSprite(dead);
        gameManager.TakeDamage();
        yield return new WaitForSeconds(3f);
        moveSpeed = 10f;
        ChangeSprite(normal);

    }
}
