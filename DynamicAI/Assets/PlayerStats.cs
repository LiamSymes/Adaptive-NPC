using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public TextMeshProUGUI availablePointsText;
    public TextMeshProUGUI healthPointsText;
    public TextMeshProUGUI attackPointsText;
    public TextMeshProUGUI defensePointsText;
    public TextMeshProUGUI confirmationText;

    public GameObject fightEnemyPanel; // Reference to the panel containing the "Fight Enemy" button
    public GameObject confirmButton; // Reference to the "Confirm" button
    public GameObject incrementButtons; // Container for all increment buttons

    private int availablePoints = 10;
    private int startingHealthPoints = 100; // Initial starting value for health
    private int startingAttackPoints = 10; // Initial starting value for attack
    private int startingDefensePoints = 20; // Initial starting value for defense

    private int healthPoints;
    private int attackPoints;
    private int defensePoints;
    private bool allPointsAllocated = false; // Track if all skill points have been allocated

    private void Start()
    {
        // Set initial stat values to starting values
        healthPoints = startingHealthPoints;
        attackPoints = startingAttackPoints;
        defensePoints = startingDefensePoints;

        UpdateUI();
    }

    public void IncrementHealth()
    {
        if (availablePoints > 0)
        {
            healthPoints += 10; // Add 10 points to health for each skill point
            availablePoints--;
            UpdateUI();
        }
    }

    public void DecrementHealth()
    {
        if (healthPoints > startingHealthPoints)
        {
            healthPoints -= 10; // Subtract 10 points from health
            availablePoints++;
            UpdateUI();
        }
    }

    public void IncrementAttack()
    {
        if (availablePoints > 0)
        {
            attackPoints += 5; // Add 5 points to attack for each skill point
            availablePoints--;
            UpdateUI();
        }
    }

    public void DecrementAttack()
    {
        if (attackPoints > startingAttackPoints)
        {
            attackPoints -= 5; // Subtract 5 points from attack
            availablePoints++;
            UpdateUI();
        }
    }

    public void IncrementDefense()
    {
        if (availablePoints > 0)
        {
            defensePoints += 5; // Add 5 points to defense for each skill point
            availablePoints--;
            UpdateUI();
        }
    }

    public void DecrementDefense()
    {
        if (defensePoints > startingDefensePoints)
        {
            defensePoints -= 5; // Subtract 5 points from defense
            availablePoints++;
            UpdateUI();
        }
    }

    public void ConfirmAllocation()
    {
        // Check if all skill points have been allocated
        if (availablePoints == 0)
        {
            // Add any additional logic here, such as saving the allocated points or transitioning to the next scene
            confirmationText.text = "Skill points allocated!";
            allPointsAllocated = true; // Set the flag to indicate all points have been allocated
            CheckFightEnemyPanel(); // Check if Fight Enemy panel should be enabled
            confirmButton.SetActive(false); // Disable the "Confirm" button
            DisableIncrementButtons(); // Disable increment buttons
        }
        else
        {
            confirmationText.text = "Allocate all skill points first!";
        }
    }

    private void UpdateUI()
    {
        availablePointsText.text = "Available Skill Points: " + availablePoints;
        healthPointsText.text = "Health: " + healthPoints;
        attackPointsText.text = "Attack: " + attackPoints;
        defensePointsText.text = "Defense: " + defensePoints;
    }

    // Function to check if all skill points have been allocated
    private void CheckFightEnemyPanel()
    {
        fightEnemyPanel.SetActive(allPointsAllocated); // Enable the panel containing the "Fight Enemy" button if all points have been allocated
    }

    // Function to disable increment buttons
    private void DisableIncrementButtons()
    {
        incrementButtons.SetActive(false);
    }
}
