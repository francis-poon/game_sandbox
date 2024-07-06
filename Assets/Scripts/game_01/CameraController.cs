using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using game_01;

namespace game_01
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]
        private GameObject target;

        private void Update()
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        }
    }
}

