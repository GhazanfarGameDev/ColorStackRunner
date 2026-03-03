using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private int score;

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }
}
