using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
   PlayerStats stats;

    void TakeDamage()
    {
        stats.hp -= 10;
    }
}
