using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullet;
    private void OnFire() {
        Instantiate(bullet, shootingPoint.position, transform.rotation);
    }
}
