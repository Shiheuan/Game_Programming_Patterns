using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public abstract class Observer : MonoBehaviour
    {
        public abstract void OnNotify(object value, NotificationType notificationType);
    }

    public abstract class Subject : MonoBehaviour
    {
        private List<Observer> _observers = new List<Observer>();

        public void RegisterObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(object value, NotificationType notificationType)
        {
            foreach (var ob in _observers)
            {
                ob.OnNotify(value, notificationType);
            }
        }
    }
}

