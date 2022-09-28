using UnityEngine;

public class Script_collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Script_iCollectible collectible = collision.GetComponent<Script_iCollectible>();
        if (collectible != null)
        {
            collectible.collect();
        }
    }
}
