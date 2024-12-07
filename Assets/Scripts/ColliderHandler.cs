using UnityEngine;

public class ColliderHandler
{
    public ColliderHandler(GameObject gameObject)
    {
        Collider2D collider;
        if (!gameObject.GetComponent<Collider2D>())
        {
            collider = gameObject.AddComponent<BoxCollider2D>();
        }
        else
        {
            collider = gameObject.GetComponent<Collider2D>();
        }
        collider.isTrigger = true;
    }
}
