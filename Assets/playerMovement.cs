using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movementInput;
    public TextMeshProUGUI textString;

    private SpriteRenderer spriteRender;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Ambil Rigidbody2D dari player
        spriteRender = rb.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Ambil input gerakan dari keyboard
        movementInput.x = Input.GetAxisRaw("Horizontal");
        if(movementInput.x > 0)
        {
            spriteRender.flipX = false;
        } if(movementInput.x < 0)
        {
            spriteRender.flipX = true;
        }
        movementInput.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Terapkan velocity ke Rigidbody2D
        rb.velocity = movementInput.normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("b-atas"))
        {
            textString.text = "Batas atas";
        }
         if(other.gameObject.CompareTag("b-bawah"))
        {
            textString.text = "Batas Bawah";

        }
         if(other.gameObject.CompareTag("b-kiri"))
        {
            textString.text = "Batas Kiri";
        }
         if(other.gameObject.CompareTag("b-kanan"))
        {
            textString.text = "Batas Kanan";
        }
    }
}
