using UnityEngine;

namespace HumbleObject
{
    public interface IBird 
    {
        Vector3 Position { get; set; }
        float MaxHeight { get; }
        float MinHeight { get; }
    }
}
