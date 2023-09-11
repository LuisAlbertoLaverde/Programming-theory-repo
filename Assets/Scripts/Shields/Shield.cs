using UnityEngine;

namespace Shields
{
    public abstract class Shield : MonoBehaviour
    {
        [SerializeField] protected string id;

        public string Id => id;
    }
}

