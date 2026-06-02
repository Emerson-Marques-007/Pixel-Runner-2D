using UnityEngine;

/// <summary>
/// Animador do personagem player.
/// Sincroniza animações com estado de movimento.
/// </summary>
public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private PlayerController playerController;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        UpdateAnimations();
    }
    
    /// <summary>
    /// Atualiza parâmetros do Animator
    /// </summary>
    private void UpdateAnimations()
    {
        if (playerController == null)
            return;
        
        // Obtém valores do controller
        bool estaNoChao = playerController.EstaNoChao();
        float velocidadeX = playerController.GetVelocidadeX();
        
        // Atualiza parâmetros
        animator.SetBool("IsGrounded", estaNoChao);
        animator.SetFloat("Speed", Mathf.Abs(velocidadeX));
    }
}
