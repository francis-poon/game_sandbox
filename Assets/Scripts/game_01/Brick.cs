using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using game_01;

namespace game_01
{
    public class Brick : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(this.gameObject);
        }
    }
}

