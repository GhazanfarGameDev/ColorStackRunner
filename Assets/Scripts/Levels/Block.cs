using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private ColorType blockColor;

    public ColorType BlockColor => blockColor;
}