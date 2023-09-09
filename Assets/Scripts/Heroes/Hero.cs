using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Heroes
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] protected string id;

        public string Id => id;
    }
}

