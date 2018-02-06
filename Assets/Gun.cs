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
    LineRenderer line;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
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

    public void knockBack(PlayerController controller)
    {
        if(controller.knockBackDown)
        {
            RaycastHit hit;
            if(Physics.SphereCast(transform.position,3, transform.forward, out hit, 10, 1, QueryTriggerInteraction.Ignore))
            {
                Debug.Log(hit.collider.name);
            }
        }
    }

    protected void shootLine(Vector3 endPos)
    {
        line.enabled = true;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, endPos);
        StopCoroutine(offShoot());
        StartCoroutine(offShoot());
    }

    IEnumerator offShoot()
    {
        yield return .1f;
        line.enabled = false;
    }

    



}
