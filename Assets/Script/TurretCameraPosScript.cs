using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCameraPosScript : MonoBehaviour
{
    public GameObject hitObject;
    public LayerMask hitLayerMask;

    public void ShootRaycast()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, Mathf.Infinity, hitLayerMask))
        {
            hitObject = hit.transform.gameObject;
        }
    }
}
