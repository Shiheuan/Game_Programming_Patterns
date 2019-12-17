using UnityEngine;

namespace NoPool
{
    public class CylinderSpawn : MonoBehaviour
    {
        [SerializeField]
        private CylinderNoPool cylinderPrefab;

        [SerializeField]
        private float refireRate = 2f;

        private float fireTimer = 0;

        void Update()
        {
            fireTimer += Time.deltaTime;
            if (fireTimer >= refireRate)
            {
                fireTimer = 0;
                Fire();
            }
        }

        private void Fire()
        {
            var shot = Instantiate(cylinderPrefab, transform.position, transform.rotation);
        }

    }

}
