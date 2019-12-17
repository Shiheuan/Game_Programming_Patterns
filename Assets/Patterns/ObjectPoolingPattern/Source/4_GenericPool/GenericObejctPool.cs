using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericPool
{

    public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component
    {
        [SerializeField]
        private T prefab;

        public static GenericObjectPool<T> Instance { get; private set; }
        private Queue<T> objects = new Queue<T>();

        void Awake()
        {
            Instance = this;
        }

        public T Get()
        {
            if (objects.Count == 0)
            {
                AddObject(1);
            }

            return objects.Dequeue();
        }

        private void AddObject(int count)
        {
            var newObj = GameObject.Instantiate(prefab);
            newObj.gameObject.SetActive(false);
            objects.Enqueue(newObj);
        }

        public void ReturnToPool(T objectToReturn)
        {
            objectToReturn.gameObject.SetActive(false);
            objects.Enqueue(objectToReturn);
        }

    }

}
