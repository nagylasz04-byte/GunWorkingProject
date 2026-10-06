using UnityEngine;

public class ShootGun : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firePos;

    public float bulletSpeed = 20f;
    public float bulletTime = 5f;

   
    public void FireBullet()
    {
        GameObject newBullet = Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        newBullet.GetComponent<Rigidbody>().linearVelocity = firePos.forward * bulletSpeed;

        Destroy(newBullet, bulletTime);
    }
}
