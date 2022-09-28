using System;
using UnityEngine;

public class Script_itemCoin : MonoBehaviour, Script_iCollectible
{
    public static event Action coinCollected;
    public void collect()
    {
        Debug.Log("coin collected");
        Destroy(gameObject);
        coinCollected?.Invoke();
    }
}
