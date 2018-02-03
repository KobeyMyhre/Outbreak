using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun {

	public override void shoot(PlayerController controller)
    {
        if (controller.fireDown && currentClip > 0)
        {
            currentClip--;
            RaycastHit hit;
           
            if (Physics.SphereCast(transform.position,1, transform.forward, out hit, 50, 1, QueryTriggerInteraction.Ignore))
            {
                if (hit.collider.tag == "enemy")
                {
                    IDamageable attempt = hit.collider.GetComponent<IDamageable>();
                    if (attempt != null)
                    {
                        attempt.takeDamage(damage);
                    }
                }
            }
            
        }
        if(currentClip <= 0 )
        {
            doReload();
        }
    }
}
