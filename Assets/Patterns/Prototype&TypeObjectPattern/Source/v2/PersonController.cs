using UnityEngine;

namespace PTv2
{
    public class PersonController : MonoBehaviour
    {
        private Weapon _weapon;
        [SerializeField]
        private Target target;

        void OnEnable()
        {
            _weapon = GetComponent<Weapon>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                _weapon.Attack(target);
            }
        }
    }


}
