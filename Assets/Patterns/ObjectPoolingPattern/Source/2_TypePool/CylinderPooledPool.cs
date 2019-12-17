using System.Collections.Generic;
using UnityEngine;

namespace TypePool
{
    public class CylinderPooledPool : MonoBehaviour
    {
        [SerializeField]
        private CylinderPooled cylinderPrefab;

        private Queue<CylinderPooled> cylinders = new Queue<CylinderPooled>();
        public static CylinderPooledPool Instance { get; private set; }

        void Awake()
        {
            Instance = this;
        }

        public CylinderPooled Get()
        {
            if (cylinders.Count == 0)
            {
                AddCylinders(1);
            }

            return cylinders.Dequeue();
        }

        private void AddCylinders(int count)
        {
            for (int i = 0; i < count; i++)
            {
                CylinderPooled cylinder = Instantiate(cylinderPrefab);
                cylinder.gameObject.SetActive(false);
                cylinders.Enqueue(cylinder);
            }
        }

        public void ReturnToPool(CylinderPooled cylinder)
        {
            cylinder.gameObject.SetActive(false);
            cylinders.Enqueue(cylinder);
        }
    }

}

