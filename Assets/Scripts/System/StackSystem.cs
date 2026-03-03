using UnityEngine;

public class StackSystem : MonoBehaviour
{
    [SerializeField] private Transform stackParent;

    private int stackCount;

    public void AddBlock(GameObject block)
    {
        block.transform.SetParent(stackParent);
        block.transform.localPosition = Vector3.up * stackCount;

        stackCount++;
    }
}