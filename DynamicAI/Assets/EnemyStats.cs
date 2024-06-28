using UnityEngine;
using TMPro;

public class EnemyStats : MonoBehaviour
{
    public TextMeshProUGUI enemyStatsText;

    private int enemyHealth;
    private int enemyAttack;
    private int enemyDefense;

    public void GenerateEnemyStats()
    {
        // Randomly generate enemy stats
        enemyHealth = Random.Range(40, 61);
        enemyAttack = Random.Range(5, 11);
        enemyDefense = Random.Range(5, 11);

        // Create a summary string of enemy stats
        string enemyStatsSummary = "Enemy Stats:\n" +
                                   "Health: " + enemyHealth + "\n" +
                                   "Attack: " + enemyAttack + "\n" +
                                   "Defense: " + enemyDefense;

        // Display the enemy stats summary on the UI Text element
        enemyStatsText.text = enemyStatsSummary;
    }
}
