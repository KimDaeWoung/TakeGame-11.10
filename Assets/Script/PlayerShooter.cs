using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform muzzle;
    public AudioSource fireSfx;

    

   
    // Update is called once per frame
    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if(keyboard.spaceKey.wasPressedThisFrame)
        {
            //총알을 만들자
            Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
            if(fireSfx != null)
            {
                fireSfx.Play();
            }
        }
    }
}
