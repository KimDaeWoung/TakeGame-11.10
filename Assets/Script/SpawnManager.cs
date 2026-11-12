using UnityEngine;



public class SpawnManager : MonoBehaviour
{
    // 허용된 GameObject 배열형식의 변수 spawnPoints를 만들어라
    public GameObject[] spawnPoints;
    // 허용된 GameObject 형식의 변수 enemyPrefab를 만들어라(오브젝트를 지정해야함)
    public GameObject enemyPrefab;
    // 허용된 함수 Spawn를 만들어라(지정된 스폰위치 중에 랜덤으로 적을 만들어라)
    public void Spawn()
    {
        // System.Random 형식의 변수 rand에 새로운 난수생성기를 넣어라
        System.Random rand = new System.Random();
        // 정수 형식의 변수 next에 rand라는 난수생성기에서 0이상 ~ spawnPoints의 길이미만의 번호를 뽑아서 넣어라
        // 스폰위치 번호를 뽑아라
        int next = rand.Next(0, spawnPoints.Length);
        // GameObject형식의 변수 g에 spawnPoints[뽑힌 수](위치)에 넣어라(길이줄이기 용)
        GameObject g = spawnPoints[next];
        // 씬에 enemyPrefab를 스폰위치의 위치와 방향대로 만들어라
        Instantiate(enemyPrefab, g.transform.position, g.transform.rotation);

        // GameObject g = spawnPoints[next].transform;
        // var g = spawnPoints[next].transform;
        // Instantiate(enemyPrefab, g.position, g.rotation);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // "SpawnPoint" 테그가 붙은 게임오브젝트를 찾아서 spawnPointds에 넣어라
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        // System.Random 형식의 변수 rand에 새로운 난수생성기를 넣어라
        System.Random rand = new System.Random();
        // 정수 형식의 변수 s에 rand라는 난수생성기에서 1이상 ~ spawnPoints의 길이미만의 번호를 뽑아서 넣어라
        int s = rand.Next(1, spawnPoints.Length);
        // 정수형식 변수 i에 0을 넣고 s가 i보다 크면 반복해라 끝나면 i에 1씩 더 해줘라(스폰위치 갯수만큼 실행해라)
        for (int i = 0; i < s; i++)
        {
            // 함수 Spawn을 실행해라
            Spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
