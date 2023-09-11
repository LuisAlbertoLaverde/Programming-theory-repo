using UnityEngine;

namespace Shields
{
    public class Shield : MonoBehaviour
    {
        [SerializeField] protected string id;

        public string Id => id;
    }
}

