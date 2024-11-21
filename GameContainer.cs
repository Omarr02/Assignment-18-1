using UnityEngine;

public class GameContainer<T>
{
    private T item;

    public void SetItem(T newItem)
    {
        item = newItem;
    }

    public T GetItem()
    {
        return item;
    }
}
