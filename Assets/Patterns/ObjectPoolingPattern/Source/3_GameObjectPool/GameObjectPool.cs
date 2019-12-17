using System.Collections.Generic;
using UnityEngine;

namespace GameObjectPool
{
    public class GameObjectPool : MonoBehaviour
    {
        [SerializeField]
        private GameObject prefab;

        private Queue<GameObject> objectPool = new Queue<GameObject>();
        public static GameObjectPool Instance { get; private set; }

        void Awake()
        {
            Instance = this;
        }

        public GameObject Get()
        {
            if (objectPool.Count == 0)
            {
                AddCylinders(1);
            }

            return objectPool.Dequeue();
        }

        private void AddCylinders(int count)
        {
            for (int i = 0; i < count; i++)
            {
                GameObject go = Instantiate(prefab);
                go.SetActive(false);
                objectPool.Enqueue(go);

                // not for concrete type
                go.GetComponent<IGameObjectPooled>().Pool = this;
            }
        }

        public void ReturnToPool(GameObject go)
        {
            go.SetActive(false);
            objectPool.Enqueue(go);
        }
    }

}

