using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;
    public GameState currentState { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        SetState(GameState.WaitingToStart);
    }

    public void SetState(GameState newState)
    {
        currentState = newState;
    }

    public bool IsPlaying()
    {
        return currentState == GameState.Playing;
    }

}
public enum GameState
{
    WaitingToStart,
    Playing,
    GameOver
}