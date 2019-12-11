using System;
using UnityEngine;

namespace ObserverPattern
{
    public class PointOfInterestWithEvents : MonoBehaviour
    {
        public static event Action<PointOfInterestWithEvents> OnPointOfInterestEntered;

        [SerializeField]
        private string _poiName;

        public string PoiName { get { return _poiName;} }

        private void OnTriggerEnter(Collider other)
        {
            //OnPointOfInterestEntered?.Invoke(this);
            if (OnPointOfInterestEntered != null)
            {
                OnPointOfInterestEntered(this);
            }
        }

    }


}
