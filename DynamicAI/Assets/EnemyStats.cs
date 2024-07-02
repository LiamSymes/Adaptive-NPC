using UnityEngine;
using TMPro;

public class EnemyStats : MonoBehaviour
{
    public TextMeshProUGUI enemyStatsText;

    private int enemyHealth;
    private int enemyAttack;
    private int enemyDefense;

    public void GenerateRandomStats()
    {
        // Generate random stats within specified ranges
        enemyHealth = Random.Range(40, 61);
        enemyAttack = Random.Range(5, 11);
        enemyDefense = Random.Range(5, 11);
    }

    public void DisplayEnemyStats()
    {
        string enemyStatsSummary = "Enemy Stats:\n" +
                                   "Health: " + enemyHealth + "\n" +
                                   "Attack: " + enemyAttack + "\n" +
                                   "Defense: " + enemyDefense;

        enemyStatsText.text = enemyStatsSummary;
    }
}
