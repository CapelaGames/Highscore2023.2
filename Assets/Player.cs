using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo) )
            {
                GameObject clickedOn = hitInfo.collider.gameObject;

                if (clickedOn.TryGetComponent<IClickable>(out IClickable clickable))
                {
                    clickable.Interact();
                }


                if (clickedOn.TryGetComponent(out IDamagable damage))
                {
                    damage.Damage(1f);
                }

            }
        }
    }
}
