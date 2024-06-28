using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyStats enemyStats;

    public void OnFightEnemyButtonClicked()
    {
        enemyStats.GenerateEnemyStats();
    }
}

