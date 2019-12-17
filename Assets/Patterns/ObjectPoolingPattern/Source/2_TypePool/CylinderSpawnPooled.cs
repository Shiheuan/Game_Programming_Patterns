using UnityEngine;

namespace TypePool
{
    public class CylinderSpawnPooled : MonoBehaviour
    {
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
            var shot = CylinderPooledPool.Instance.Get();
            shot.transform.rotation = transform.rotation;
            shot.transform.position = transform.position;
            shot.gameObject.SetActive(true);
        }

    }

}
