using UnityEngine;

namespace PTv1
{
    public class Target : MonoBehaviour
    {
        [SerializeField]
        private int currentHealth = 10;

        public void TakeDamage(int amount)
        {
            currentHealth -= amount;
        }

        internal void Freeze(int second)
        {
            Debug.Log("Frozen ForceMode " + second);
        }

        internal void Stun(int second)
        {
            Debug.Log("Stunned for" + second);
        }
    }

}

