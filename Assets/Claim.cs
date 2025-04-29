using UnityEngine;
using TMPro;

[System.Serializable]
public class Claim
{
    public string ClaimantName;
    public string ClaimantDOB;
    public string ClaimantPolicyNumber;
    public string ClaimantAddress;
    public int ClaimantPhoneNumber;
    public float ClaimantAmount;
    public string MedicalReport;
    public string AdditionalNotes;
    public string Signature;
    public Sprite Image1;
    public Sprite Image2;

    public string ClaimType; // E.g., "Car Accident", "Medical", "Fire Damage"
    public bool IsValid; // Whether the claim is fraudulent or genuine
    public bool IsApproved = false; // Outcome of the claim
    public TMP_FontAsset HandwritingStyle;
    // Constructor to set claim details
    public Claim(string ClaimantName, string ClaimType, string DOB, string PolicyNumber)
    {
        this.ClaimantName = ClaimantName;
        this.ClaimType = ClaimType;
        this.ClaimantDOB = DOB;
        this.ClaimantPolicyNumber = PolicyNumber;
    }
}

