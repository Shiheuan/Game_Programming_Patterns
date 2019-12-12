using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HumbleObject
{
    public class BirdSplit : MonoBehaviour, IBird
    {
        private BirdController _birdController;
        public Vector3 Position
        {
            get { return transform.position; }// get {return transform.position;}
            set { transform.position = value; } //{ transform.position = value; }
        }

        [SerializeField]
        private float _maxHeight = 3;
        [SerializeField]
        private float _minHeight = -3;

        public float MaxHeight { get { return _maxHeight; } }
        public float MinHeight { get { return _minHeight; } }

        void Awake()
        {
            _birdController = new BirdController(this);
        }
        // Update is called once per frame
        void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            _birdController.Move(vertical);
        }
        
    }
}
