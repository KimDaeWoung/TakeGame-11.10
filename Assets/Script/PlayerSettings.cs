using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    public int HP = 100;

    public AudioSource fireSfx;


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

    }

    private void Update()
    {
        if (fireSfx != null)
        {
            fireSfx.Play();
        }
    }
}
