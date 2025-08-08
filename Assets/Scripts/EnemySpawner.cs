using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    private float[] arrPosX = { -2.2f, -1.1f, 0f, 1.1f, 2.2f };
    void SpawnEnemy(float posX, int idx)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
        Instantiate(enemies[idx], spawnPos, Quaternion.identity);
    }

    void Start()
    {
        foreach (float posX in arrPosX)
        {
            int index = Random.Range(0, enemies.Length);
            SpawnEnemy(posX, index);
        }
    }
}
