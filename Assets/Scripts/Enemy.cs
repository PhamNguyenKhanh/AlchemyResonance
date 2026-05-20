using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 50f;
    private float currentHealth;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.gray; // ??m b?o màu g?c là xám
    }

    // Hàm này s? ???c Player g?i khi thanh ki?m chém trúng
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("Dummy b? chém! Máu còn: " + currentHealth);

        // ??i sang màu ?? ch?p nhoáng ?? t?o c?m giác "b? ?au"
        spriteRenderer.color = Color.red;
        Invoke("ResetColor", 0.1f); // Sau 0.1s t? ??ng g?i hàm ResetColor

        // N?u máu v? 0 -> B? cook
        if (currentHealth <= 0)
        {
            Debug.Log("Dummy ?ã bay màu!");
            Destroy(gameObject); // Xóa v?t th? này kh?i game
        }
    }

    void ResetColor()
    {
        spriteRenderer.color = Color.gray;
    }
}