using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Howley
{
    [RequireComponent(typeof(AABB))]
    public class SpringBlock : MonoBehaviour
    {
        AABB aabb;

        void Start()
        {
            aabb = GetComponent<AABB>();
            Zone.main.powerups.Add(aabb);
        }

        void Update()
        {

        }
        private void OnDestroy()
        {
            if (Zone.main == null) return;
            Zone.main.powerups.Remove(aabb);
        }
        public void PlayerHit(PlayerMovement pm)
        {
            pm.LauchPlayer(new Vector3(0, 25, 0));
        }
    }
}

