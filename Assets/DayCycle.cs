using UnityEngine;
using UnityEngine.UI;

public class DayCycle : MonoBehaviour
{
    public float workDayDuration = 300f; // Workday duration in seconds (e.g., 5 minutes)
    private float timeLeft;

    public Text timeLeftText;
    public Text performanceText;

    private int approvedClaims = 0;
    private int deniedClaims = 0;

    void Start()
    {
        timeLeft = workDayDuration;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeLeftText.text = $"Time Left: {Mathf.Ceil(timeLeft)}s";

        if (timeLeft <= 0)
        {
            EndWorkday();
        }
    }

    void EndWorkday()
    {
        performanceText.text = $"Claims Approved: {approvedClaims}\nClaims Denied: {deniedClaims}";
        Debug.Log($"End of Day: {approvedClaims} approved, {deniedClaims} denied.");
        // Update salary and family status based on performance
    }

    public void ApproveClaim()
    {
        approvedClaims++;
    }

    public void DenyClaim()
    {
        deniedClaims++;
    }
}

