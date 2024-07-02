using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject fightEnemyPanel;
    public GameObject startPanel;
    public GameObject enemyStatsPanel;
    public GameObject playerStatsPanel;
    public GameObject playerSkillPointsPanel;
    public EnemyStats enemyStats;

    public void StartGame()
    {
        // Enable the panel containing the "Fight Enemy" button
        startPanel.SetActive(false);
        enemyStatsPanel.SetActive(false);
        playerStatsPanel.SetActive(true);
        playerSkillPointsPanel.SetActive(true);
    }

    public void FightEnemy()
    {
        Debug.Log("FightEnemy method called."); // Check if this log appears in the console
                                                // Generate random stats for the enemy
        enemyStats.GenerateRandomStats();

        // Enable the panel containing the "Fight Enemy" button
        enemyStatsPanel.SetActive(true);
        fightEnemyPanel.SetActive(false);
        enemyStats.DisplayEnemyStats();
    }

}
