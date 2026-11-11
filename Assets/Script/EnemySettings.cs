using UnityEngine;

public class EnemySettings : MonoBehaviour
{
    public int HP = 100;
    public float fireSpeed = 1.0f;
    private float t = 0;
    public GameObject bulletPrefab;
    public Transform muzzle;
    public GameManger GameManager;

    public void TakeDamage(int damage)
    {
        if (HP == 0)
            return;
        
        
        
        HP = HP - damage;
        if (HP <= 0)
        {
            HP = 0;
            //HP가 0이거나 더 적으면 GameManager.DecreaseEnemyCount() 실행해라
            GameManager.DecreaseEnemyCount();
            Destroy(gameObject);
        }
        
        if (HP == 0)
        {
            Destroy(gameObject);
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //public GameManger GameManager를 지정하지않아서 GameManager에 아무것도 없으면 자동으로 찾아서 넣어라
        if (GameManager == null)
        {
            GameManager = FindAnyObjectByType<GameManger>();
        }
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
