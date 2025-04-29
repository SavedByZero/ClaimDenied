using UnityEngine;

using System.Collections.Generic;
using UnityEngine;

public class ClaimManager : MonoBehaviour
{
    public ClaimUI claimUI;
    public ClaimPile AllClaims;
    private Stack<Claim> dailyClaims;
    

    // Simulate a workday
    void Start()
    {
        selectClaimsFromPile(5);
        DisplayNextClaim();
    }

    void selectClaimsFromPile(int count)
    {
        dailyClaims = new Stack<Claim>();  // 5 claims per day
        for(int i=0; i < count; i++)
        {
            dailyClaims.Push(AllClaims.PullClaim());
        }


        /*dailyClaims[0] = new Claim("John Doe", "Car Accident", true, "Accident occurred at intersection A.");
        dailyClaims[1] = new Claim("Jane Smith", "Medical Emergency", false, "Requires surgery but papers seem forged.");
        dailyClaims[2] = new Claim("Alex Brown", "Home Damage", true, "Fire damage with insurance paperwork intact.");
        dailyClaims[3] = new Claim("Emily White", "Car Accident", false, "Claim seems exaggerated and lacks valid photos.");
        dailyClaims[4] = new Claim("Chris Black", "Medical Emergency", true, "Legitimate hospital bills and medical records.");
        */
        // Shuffle or randomize claims for variety
    }

    void DisplayNextClaim()
    {
        if (dailyClaims.Count > 0)
        {
            Claim nextClaim = dailyClaims.Pop();
            claimUI.SetClaim(nextClaim);
           
        }
        else
        {
            EndDay();
        }
    }

    void EndDay()
    {
        Debug.Log("End of the workday!");
        // Check performance and apply any consequences based on decisions made during the day.
    }
}

