using System.Security.Cryptography;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public int enemyCount;
    public GameObject winPanel;
    public GameObject loss;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //enemies에 게임오브젝트의 Enemy테그가 달린 것을 넣어라 'var=넣은 것에 따라 변수의 타입이 바뀜'
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //enemyCount에 enemies.Length의 길이를 정수로 넣어라 '위에 정수로 지정되어 있어서'
        enemyCount = enemies.Length;
        if(winPanel != null)
        {
            winPanel.SetActive(false);
        }
        if (loss != null)
        {
            loss.SetActive(false);
        }
    }

    public void DecreaseEnemyCount()
    {
        //enemyCount = enemyCount - 1;
        //enemyCount 를 1씩 줄여라
        enemyCount -= 1;
        //enemyCount 0과 같으면  Debug.Log("<color=yellow>모든 적을 해치웠습니다!</color>");를 출력해라
        if (enemyCount == 0)
        {
            winPanel.SetActive(true);
            Debug.Log("<color=yellow>모든 적을 해치웠습니다!</color>");
        }
    }
    public void LossPanel()
    {
        if (loss != null)
        {
            loss.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
