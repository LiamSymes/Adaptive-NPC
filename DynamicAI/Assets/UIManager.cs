using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject fightEnemyPanel;
    public GameObject startPanel;
    public GameObject enemyStatsPanel;
    public GameObject playerStatsPanel;
    public GameObject playerSkillPointsPanel;

    public void StartGame()
    {
        // Enable the panels for player stats and skill points allocation
        playerStatsPanel.SetActive(true);
        playerSkillPointsPanel.SetActive(true);
        startPanel.SetActive(false);
    }
}
