using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimWeapon : MonoBehaviour
{
   private Transform aimTransform;
    public GameObject bullet;
    public Transform firePoint;
    public float bulletSpeed = 50;
    float lookAngle;
    Vector3 lookDirection;
    private Animator aimAnimator;

   private void Awake() {
        aimTransform = transform.Find("Aim");
        aimAnimator = aimTransform.GetComponent<Animator>();
   }

   private void Update() {
        HandleAiming();
        HandleShooting();
 
   }

    private void HandleAiming(){
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        
        Vector3 aimDirection = (lookDirection - transform.position);
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        aimTransform.eulerAngles = new Vector3(0,0, angle);
        Debug.Log(angle);
    }

    private void HandleShooting(){
        if (Input.GetMouseButtonDown(0))
        {
            aimAnimator.SetTrigger("Shoot");
            GameObject bulletClone = Instantiate(bullet);
            bulletClone.transform.position = firePoint.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletSpeed;
        }
    }
    
}
