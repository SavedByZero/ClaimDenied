using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Text salaryText;
    public Text familyStatusText;
    public Text performanceText;

    private int salary = 50; // Base salary
    private int familyHealth = 100;

    void Update()
    {
       
    }

    // Modify salary and family health based on performance
    public void UpdateStats(int approved, int denied)
    {
        salary += approved * 10; // Add $10 for every claim approved
        familyHealth -= denied * 5; // Deduct health for each denied claim

        salaryText.text = $"Salary: ${salary}";
        familyStatusText.text = $"Family Health: {familyHealth}%";
        performanceText.text = $"Claims Approved: {approved} | Denied: {denied}";
    }
}

