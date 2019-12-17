using UnityEngine;

namespace TypePool
{
    public class CylinderPooled : MonoBehaviour
    {
        public float moveSpeed = 30f;
        private float lifeTime;
        private float maxLifeTime = 5f;

        void OnEnable()
        {
            lifeTime = 0f;
        }
        void Update()
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            lifeTime += Time.deltaTime;
            if (lifeTime > maxLifeTime)
            {
                CylinderPooledPool.Instance.ReturnToPool(this);
            }
        }
    }

}

