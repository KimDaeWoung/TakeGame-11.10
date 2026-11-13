using Tanks.Complete;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;


public class PlayerSettings : MonoBehaviour
{
    public int HP = 100;

    public AudioSource fireSfx;
    public GameManger GameManager;


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
            GameManager.LossPanel();
            Debug.Log("Player가 죽었습니다.");
        }

    }

    void Start()
    {
        //public GameManger GameManager를 지정하지않아서 GameManager에 아무것도 없으면 자동으로 찾아서 넣어라
        if (GameManager == null)
        {
            GameManager = FindAnyObjectByType<GameManger>();
        }

        if (GameManager == null)
        {
            GameManager = FindAnyObjectByType<GameManger>();
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
