using UnityEngine;

public static class DiscrepancyEvaluator 
{
    public static bool IsDiscrepancy(string A, string B)
    {
        return !A.Equals(B);
    }

    public static int ShowDiscrepancy(string A, string B)
    {
        if (IsDiscrepancy(A, B))
        {
            return string.Compare(A, B);
        }

        return 0;
    }
}
