using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerStatsSO playerStats; // Reference to the HealthSystem component of the player
    public RectTransform barFill; // Reference to the fill image of the health bar

    private void Start()
    {
        if (playerStats == null)
        {
            Debug.LogError("HealthSystem component not found on the player!");
            return;
        }

        // Update the health bar initially
        UpdateHealthBar();
    }

    private void Update()
    {
        // Continuously update the health bar to reflect any changes in the player's health
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        // Calculate the fill amount based on the current health percentage
        float fillAmount = playerStats.Health / playerStats.maxHealth;

        // Clamp the fill amount between 0 and 1
        fillAmount = Mathf.Clamp01(fillAmount);

        // Update the width of the fill image of the health bar
        barFill.localScale = new Vector3(fillAmount, 1f, 1f);
    }
}
