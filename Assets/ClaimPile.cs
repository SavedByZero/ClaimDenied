using UnityEngine;
using System.Collections.Generic;

public class ClaimPile : MonoBehaviour
{
    public Claim[] Claims;
    public delegate void NoMoreClaims();
    public NoMoreClaims onNoMoreClaims;
    private Stack<Claim> _claimStack;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _claimStack = new Stack<Claim>();
        for(int i=Claims.Length-1; i >= 0; i--)
        {
            _claimStack.Push(Claims[i]);
        }
        
    }

    public Claim PullClaim()
    {
        if (_claimStack.Count > 0)
        {
            return _claimStack.Pop();
        }
        else
        {
            onNoMoreClaims?.Invoke();
        }
        return null;

    }
}
