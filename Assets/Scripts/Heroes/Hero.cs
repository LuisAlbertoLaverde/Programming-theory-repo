using UnityEngine;
namespace Heroes
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] protected string id;

        public string Id => id;
    }
}

