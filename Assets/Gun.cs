using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public float gunRange;
    public float damage;
    public int maxClip;
    public int currentClip;
    public int maxAmmo;
    public float reloadTime;
    float reloadTimer;


    private void Start()
    {
        
        currentClip = maxClip;
        reloadTimer = reloadTime;
    }

    public virtual void shoot(PlayerController controller)
    {
        
    }

    protected void doReload()
    {
        reloadTimer -= Time.deltaTime;
        if(reloadTimer <= 0)
        {
            int desiredAmmo = maxClip - currentClip;
            if (maxAmmo > desiredAmmo)
            {
                currentClip += desiredAmmo;
                maxAmmo -= desiredAmmo;
            }
            else
            {
                desiredAmmo = maxAmmo;
                currentClip += desiredAmmo;
                maxAmmo = 0;
            }
            reloadTimer = reloadTime;
        }
        
    }
	
}
