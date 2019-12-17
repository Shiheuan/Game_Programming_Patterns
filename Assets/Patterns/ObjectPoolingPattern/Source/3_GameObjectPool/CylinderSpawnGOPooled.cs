using UnityEngine;

namespace GameObjectPool
{
    public class CylinderSpawnGOPooled : MonoBehaviour
    {
        [SerializeField]
        private float refireRate = 2f;
        [SerializeField]
        private GameObjectPool pool;

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
            var shot = pool.Get();
            shot.transform.rotation = transform.rotation;
            shot.transform.position = transform.position;
            shot.gameObject.SetActive(true);
        }

    }

}
