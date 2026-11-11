using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    public float lifeTime = 1.5f;
    public int damage = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rigid = GetComponent<Rigidbody>();
        rigid.linearVelocity = transform.forward * speed;
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemySettings e = collision.gameObject.GetComponent<EnemySettings>();
            if (e != null)
            {
                e.TakeDamage(damage);        
            }

            Destroy(gameObject);
        }

        if (collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }

    }

}
