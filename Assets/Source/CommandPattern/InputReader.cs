using UnityEngine;

namespace CommandPattern
{
    public class InputReader : MonoBehaviour
    {
        public Vector3 ReadInput()
        {
            float x = 0f;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                x = -1f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                x = 1f;
            }

            float y = 0f;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                y = 1f;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                y = -1f;
            }

            if (x != 0f || y != 0f)
            {
                Vector3 direction = new Vector3(x, y, 0f);
                return direction;
            }

            return Vector3.zero;
        }

        internal bool ReadUndo()
        {
            return Input.GetKey(KeyCode.Backspace);
        }

        internal float ReadScale()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                return 1f;
            }

            if (Input.GetKey(KeyCode.A))
            {
                return -1f;
            }

            return 0f;
        }
        
    }
}

