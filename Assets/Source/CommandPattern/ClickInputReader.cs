using UnityEngine;

namespace CommandPattern
{
    public class ClickInputReader : MonoBehaviour
    {
        public Vector3? GetInputPosition()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hitInfo;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hitInfo))
                {
                    return hitInfo.point;
                }
            }

            return null;
        }

        internal bool ReadUndo()
        {
            return Input.GetKey(KeyCode.Backspace);
        }
        
    }
}

