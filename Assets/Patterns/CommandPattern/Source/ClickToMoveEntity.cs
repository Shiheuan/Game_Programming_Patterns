using System.Collections;
using UnityEngine;

namespace CommandPattern
{
    [RequireComponent(typeof(ClickInputReader))]
    [RequireComponent(typeof(CommandProcessor))]
    public class ClickToMoveEntity : MonoBehaviour, IEntity
    {
        private ClickInputReader _clickInputReader;
        private CommandProcessor _commandProcessor;
        private Coroutine _coroutine;

        void Awake()
        {
            _clickInputReader = GetComponent<ClickInputReader>();
            _commandProcessor = GetComponent<CommandProcessor>();
        }

        // Update is called once per frame
        void Update()
        {
            var position = _clickInputReader.GetInputPosition();
            if (position != null)
            {
                _commandProcessor.ExecuteCommand(new MoveToCommand(this, position.Value));
            }

            //if (_clickInputReader.ReadUndo()) // can't use the origin
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                _commandProcessor.Undo();
            }
        }

        public void MoveFromTo(Vector3 startPosition, Vector3 endPosition)
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }

            _coroutine = StartCoroutine(MoveFromToAsync(startPosition, endPosition));
        }

        IEnumerator MoveFromToAsync(Vector3 startPosition, Vector3 endPosition)
        {
            float elapsed = 0f;
            while (elapsed < 1f)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, elapsed);
                elapsed += Time.deltaTime;
                yield return null;
            }

            transform.position = endPosition;
        }
    }

}

