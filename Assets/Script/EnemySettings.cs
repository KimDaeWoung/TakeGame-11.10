using UnityEngine;

public class EnemySettings : MonoBehaviour
{
    public int HP = 100;

    public int TakeDamage(int damage)
    {
        if(HP < 0)
        {
            HP = 0;
        }
        return HP;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
