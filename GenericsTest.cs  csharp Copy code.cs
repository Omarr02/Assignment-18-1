using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        // Create GameContainer for a string
        GameContainer<string> potionContainer = new GameContainer<string>();
        potionContainer.SetItem("Healing Potion");

        // Log the stored item
        string storedItem = potionContainer.GetItem();
        Debug.Log($"Stored item: {storedItem}");

        // Log the description of the item
        string description = GameUtils.DescribeItem(storedItem);
        Debug.Log(description);
    }
}
