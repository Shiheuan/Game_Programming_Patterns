using UnityEngine;

namespace PTv0
{
    public class Target : MonoBehaviour
    {
        private int currentHealth = 10;

        public void TakeDamage(int amount)
        {
            currentHealth -= amount;
        }
    }

}

