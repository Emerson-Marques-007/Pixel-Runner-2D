using UnityEngine;

/// <summary>
/// Boss final do jogo.
/// Possui múltiplas fases e padrões complexos de ataque.
/// </summary>
public class BossController : MonoBehaviour
{
    [SerializeField] private int bossHealth = 5;
    [SerializeField] private float speed = 2f;
    [SerializeField] private Transform leftBound;
    [SerializeField] private Transform rightBound;
    [SerializeField] private int damageAmount = 1;
    
    private int currentHealth;
    private int currentPhase = 1;
    private Vector3 targetPosition;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentHealth = bossHealth;
        SetRandomTarget();
    }
    
    void FixedUpdate()
    {
        MoveBoss();
    }
    
    /// <summary>
    /// Move o boss de forma inteligente
    /// </summary>
    private void MoveBoss()
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * speed * currentPhase, rb.velocity.y);
        
        // Flip sprite
        if (direction.x < 0)
            spriteRenderer.flipX = true;
        else if (direction.x > 0)
            spriteRenderer.flipX = false;
        
        // Novo alvo quando chegar
        if (Vector3.Distance(transform.position, targetPosition) < 0.5f)
        {
            SetRandomTarget();
        }
    }
    
    /// <summary>
    /// Define alvo aleatório
    /// </summary>
    private void SetRandomTarget()
    {
        float randomX = Random.Range(leftBound.position.x, rightBound.position.x);
        targetPosition = new Vector3(randomX, transform.position.y, transform.position.z);
    }
    
    /// <summary>
    /// Recebe dano do jogador
    /// </summary>
    public void TakeDamage(int damage = 1)
    {
        currentHealth -= damage;
        
        // Aumenta dificuldade conforme leva dano
        if (currentHealth <= bossHealth / 3)
            currentPhase = 3;
        else if (currentHealth <= 2 * bossHealth / 3)
            currentPhase = 2;
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    /// <summary>
    /// Boss morre
    /// </summary>
    private void Die()
    {
        if (AudioManager.Instance != null)
            AudioManager.Instance.PlaySFX("boss_defeat");
        
        Destroy(gameObject);
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null && !playerHealth.IsInvencible())
            {
                playerHealth.TakeDamage(damageAmount);
            }
        }
    }
}
