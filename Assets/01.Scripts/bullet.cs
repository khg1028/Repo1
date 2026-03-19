using UnityEngine;
using UnityEngine.InputSystem;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject Firepos;
    int speed = 4;
    // Update is called once per frame
    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject bullet = Instantiate(bulletPrefab); ;
            bullet.transform.position = Firepos.transform.position;
            bullet.transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }


}
