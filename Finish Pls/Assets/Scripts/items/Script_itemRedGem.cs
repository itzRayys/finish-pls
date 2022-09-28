using UnityEngine;
using System;

public class Script_itemRedGem : MonoBehaviour, Script_iCollectible
{
    public static event Action redGemCollected;
    public void collect()
    {
        Debug.Log("*red gem collected*");
        Destroy(gameObject);
        redGemCollected?.Invoke();
    }
}
