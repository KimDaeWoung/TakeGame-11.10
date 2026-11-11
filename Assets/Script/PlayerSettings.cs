using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    public int HP = 100;


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
            Debug.Log("Player가 죽었습니다.");
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
}
