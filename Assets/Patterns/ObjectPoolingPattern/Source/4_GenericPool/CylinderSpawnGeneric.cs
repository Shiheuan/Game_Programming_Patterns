using UnityEngine;

namespace GenericPool
{
    public class CylinderSpawnGeneric : MonoBehaviour
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
            var shot = ShotPool.Instance.Get();
            shot.transform.rotation = transform.rotation;
            shot.transform.position = transform.position;
            shot.gameObject.SetActive(true);
        }

    }

}

