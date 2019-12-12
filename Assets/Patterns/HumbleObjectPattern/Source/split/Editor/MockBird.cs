using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HumbleObject
{
    public class MockBird : IBird
    {
        public Vector3 Position { get; set; }
        public float MaxHeight { get; set; }
        public float MinHeight { get; set; }
    }


}
