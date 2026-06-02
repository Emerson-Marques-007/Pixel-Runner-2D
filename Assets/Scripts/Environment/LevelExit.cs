using UnityEngine;

/// <summary>
/// Portal de saída do nível.
/// Quando o jogador entra, passa para o próximo nível.
/// </summary>
public class LevelExit : MonoBehaviour
{
    [SerializeField] private ParticleSystem exitEffect;
    
    private bool hasBeenUsed = false;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasBeenUsed)
            return;
        
        if (collision.CompareTag("Player"))
        {
            Exit();
        }
    }
    
    /// <summary>
    /// Sai do nível
    /// </summary>
    private void Exit()
    {
        hasBeenUsed = true;
        
        // Som
        if (AudioManager.Instance != null)
            AudioManager.Instance.PlaySFX("victory");
        
        // Efeito visual
        if (exitEffect != null)
        {
            Instantiate(exitEffect, transform.position, Quaternion.identity);
        }
        
        // Mostra painel de vitória
        if (UIManager.Instance != null)
            UIManager.Instance.ShowVictoryPanel();
        
        // Carrega próximo nível após delay
        Invoke("LoadNextLevel", 2f);
    }
    
    private void LoadNextLevel()
    {
        if (GameManager.Instance != null)
            GameManager.Instance.LoadNextLevel();
    }
}
