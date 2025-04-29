using UnityEngine;

using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClaimUI : MonoBehaviour
{
    public TextMeshProUGUI claimantNameText;
    public TextMeshProUGUI ClaimantAddressText;
    public TextMeshProUGUI ClaimantSignature;
    public TextMeshProUGUI ClaimantDOBText;
    public TextMeshProUGUI PhoneText;
    public TextMeshProUGUI PolicyNoText;
    public TextMeshProUGUI claimTypeText;
    public TextMeshProUGUI ClaimAmountText;
    public TextMeshProUGUI MedicalReport;
    public TextMeshProUGUI documentsInfoText;
    public Button approveButton;
    public Button denyButton;

    private Claim currentClaim;

    public void SetClaim(Claim claim)
    {
        currentClaim = claim;
        claimantNameText.text = $"{claim.ClaimantName}";
        ClaimantSignature.text = claim.Signature;
        ClaimantSignature.font = claim.HandwritingStyle; 
        ClaimantAddressText.text = claim.ClaimantAddress;
        ClaimantDOBText.text = claim.ClaimantDOB;
        PhoneText.text = claim.ClaimantPhoneNumber.ToString();
        PolicyNoText.text = claim.ClaimantPolicyNumber;
        claimTypeText.text = $"{claim.ClaimType}";
        ClaimAmountText.text = claim.ClaimantAmount.ToString();
        MedicalReport.text = claim.MedicalReport;
        documentsInfoText.text = claim.AdditionalNotes;
       

        approveButton.onClick.RemoveAllListeners();
        denyButton.onClick.RemoveAllListeners();

        approveButton.onClick.AddListener(ApproveClaim);
        denyButton.onClick.AddListener(DenyClaim);
    }

    private void ApproveClaim()
    {
        currentClaim.IsApproved = true;
        Debug.Log($"Claim approved: {currentClaim.ClaimantName}");
        // Update family or performance metrics based on the decision
    }

    private void DenyClaim()
    {
        currentClaim.IsApproved = false;
        Debug.Log($"Claim denied: {currentClaim.ClaimantName}");
        // Update family or performance metrics based on the decision
    }
}

