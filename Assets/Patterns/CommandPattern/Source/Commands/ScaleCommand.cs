using UnityEngine;

namespace CommandPattern
{
    public class ScaleCommand : Command
    {
        private float _scaleFactor;

        public ScaleCommand(IEntity entity, float scaleDirection) : base(entity)
        {
            _scaleFactor = scaleDirection == 1 ? 1.1f : 0.9f;
        }

        public override void Execute()
        {
            _entity.transform.localScale *= _scaleFactor;
        }

        public override void Undo()
        {
            _entity.transform.localScale /= _scaleFactor;
        }
    }

}

