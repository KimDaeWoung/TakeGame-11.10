using UnityEngine;

public class EnemySettings : MonoBehaviour
{
    public int HP = 100;
    public float fireSpeed = 1.0f;
    private float t = 0;
    public GameObject bulletPrefab;
    public Transform muzzle;

    public void TakeDamage(int damage)
    {
        if (HP == 0)
            return;
        
        
        
        HP = HP - damage;
        if (HP < 0)
        {
            HP = 0;
        }
        
        if (HP == 0)
        {
            Destroy(gameObject);
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime; // 1프레임 당 시간
        if(t > fireSpeed)
        {
            t = 0; //초기화
            Fire();
        }

    }

    void Fire()
    {
        Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
    }
}
