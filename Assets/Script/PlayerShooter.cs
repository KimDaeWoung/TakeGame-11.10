using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform muzzle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if(keyboard.spaceKey.wasPressedThisFrame)
        {
            //총알을 만들자
            Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
        }
    }
}
