# Color Stack Runner

A hyper-casual runner prototype built in **Unity 6 (6000.2)** with **C#**.

The player runs forward automatically and steers left and right. Collecting blocks that match the player's colour stacks them up and adds to the score. Touching a block of a different colour ends the run.

## Gameplay

- **Auto-run** forward with mouse / swipe-style horizontal steering
- **Colour matching** across four colours: red, green, blue and yellow
- **Stacking**: each matching block is added on top of the player's stack
- **Game over** on hitting a block of the wrong colour

## Code structure

```
Assets/Scripts
├── Player
│   ├── PlayerMovement.cs    // forward run + horizontal steering
│   ├── PlayerColor.cs       // current colour and material swap
│   └── PlayerCollision.cs   // match → stack and score, mismatch → game over
├── System
│   ├── GameStateManager.cs  // WaitingToStart / Playing / GameOver state (singleton)
│   ├── StackSystem.cs       // parents collected blocks into a growing stack
│   └── ScoreSystem.cs       // score tracking
└── Levels
    └── Block.cs             // colour data for each collectable block
```

Each system has a single responsibility, and the player components talk to them through small public methods, so new mechanics (gates that change colour, multipliers, level progression) can be added without rewriting existing code.

## Running it

1. Open the project in **Unity 6000.2.13f1** or newer.
2. Open `Assets/Scenes/SampleScene.unity` and press **Play**.

## Author

**Ghazanfar Ali**, Senior Unity Game Developer · [Portfolio](https://ghazanfargamedev.github.io/) · [LinkedIn](https://www.linkedin.com/in/ghazanfar-ali-726873100/)
