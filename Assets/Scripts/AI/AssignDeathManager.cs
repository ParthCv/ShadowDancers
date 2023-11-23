using UnityEngine;

public class AssignDeathManager : MonoBehaviour
{
    public DeathManager deathManager;

    void Start()
    {
        // Find all objects with the EnemyAI script
        EnemyAI[] enemyAIs = FindObjectsOfType<EnemyAI>();

        // Assign the DeathManager reference to each EnemyAI
        foreach (EnemyAI enemyAI in enemyAIs)
        {
            enemyAI.deathManager = deathManager;
        }
    }
}

