using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_magnet : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<Script_attract>(out Script_attract attract))
        {
            attract.setTarget(transform.parent.position);
        }
    }
}
