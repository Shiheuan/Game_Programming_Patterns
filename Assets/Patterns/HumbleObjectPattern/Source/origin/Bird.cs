using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HumbleObject
{
    public class Bird : MonoBehaviour
    {
        [SerializeField]
        private int maxHeight = 3;
        [SerializeField]
        private int minHeight = -3;

        // Update is called once per frame
        void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            Move(vertical);
        }

        private void Move(float vertical)
        {
            transform.position += Vector3.up * vertical;
            if (transform.position.y > maxHeight)
                transform.position = new Vector3(transform.position.x, maxHeight, transform.position.z);
            if (transform.position.y < minHeight)
                transform.position = new Vector3(transform.position.x, minHeight, transform.position.z);
        }
    }

}

