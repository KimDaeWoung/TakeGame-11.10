using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 30f;
    public float lifeTime = 1.5f;
    public int damage = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rigid = GetComponent<Rigidbody>();
        rigid.linearVelocity = transform.forward * speed;
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerSettings e = collision.gameObject.GetComponent<PlayerSettings>();
            if (e != null)
            {
                e.TakeDamage(damage);
            }

            Destroy(gameObject);

        }

        if (collision.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }

}
