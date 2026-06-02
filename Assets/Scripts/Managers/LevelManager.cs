using UnityEngine;

/// <summary>
/// Gerenciador de cada nível.
/// Controla spawn do player, checkpoints e objetivo do nível.
/// </summary>
public class LevelManager : MonoBehaviour
{
    [SerializeField] private Transform playerSpawnPoint;
    [SerializeField] private int levelNumber = 1;
    [SerializeField] private string levelName = "Level";
    
    private int coinsInLevel = 0;
    private int coinsCollected = 0;
    
    void Start()
    {
        // Inicia música do nível
        if (AudioManager.Instance != null)
        {
            string musicName = levelNumber switch
            {
                1 or 2 => "level_easy",
                3 or 4 => "level_medium",
                5 => "level_boss",
                _ => "level_easy"
            };
            
            AudioManager.Instance.PlayMusic(musicName);
        }
        
        // Conta moedas no nível
        CoinCollectable[] coins = FindObjectsOfType<CoinCollectable>();
        coinsInLevel = coins.Length;
        
        Debug.Log($"Nível {levelNumber}: {coinsInLevel} moedas disponíveis");
    }
    
    /// <summary>
    /// Registra coleta de moeda
    /// </summary>
    public void RegisterCoinCollection()
    {
        coinsCollected++;
        Debug.Log($"Moedas: {coinsCollected}/{coinsInLevel}");
    }
    
    public int GetCoinsInLevel() => coinsInLevel;
    public int GetCoinsCollected() => coinsCollected;
    public int GetLevelNumber() => levelNumber;
}
