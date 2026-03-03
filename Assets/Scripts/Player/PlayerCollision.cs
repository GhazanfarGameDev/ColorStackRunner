using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerColor playerColor;
    private StackSystem stackSystem;
    private ScoreSystem scoreSystem;

    private void Awake()
    {
        playerColor = GetComponent<PlayerColor>();
        stackSystem = GetComponent<StackSystem>();
        scoreSystem = FindFirstObjectByType<ScoreSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Block block = other.GetComponent<Block>();

        if (block == null)
            return;

        if (block.BlockColor == playerColor.CurrentColor)
        {
            stackSystem.AddBlock(other.gameObject);
            scoreSystem.AddScore(1);
        }
        else
        {
            GameStateManager.instance.SetState(GameState.GameOver);
        }
    }
}
