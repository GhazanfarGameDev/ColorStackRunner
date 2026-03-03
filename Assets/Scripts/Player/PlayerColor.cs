using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    [SerializeField] private ColorType currentColor;
    [SerializeField] private Renderer playerRendrer;

    [SerializeField] private Material redMat;
    [SerializeField] private Material greenMat;
    [SerializeField] private Material blueMat;
    [SerializeField] private Material yellowMat;

    public ColorType CurrentColor => currentColor;

    public void SetColor(ColorType newColor)
    {
        currentColor = newColor;
        UpdateVisual();
    }
    private void UpdateVisual()
    {
        switch (currentColor)
        {
            case ColorType.Red:
                playerRendrer.material = redMat;
                break;
            case ColorType.Green:
                playerRendrer.material = greenMat;
                break;
            case ColorType.Blue:
                playerRendrer.material = blueMat;
                break;
            case ColorType.Yellow:
                playerRendrer.material = yellowMat;
                break;
        }
    }
}

public enum ColorType
{
    Red, Green, Blue, Yellow
}