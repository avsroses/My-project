using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject myPrefab;
    float timestamp;
    float spawnRate = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timestamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        if (elapsedTime > timestamp + spawnRate)
        {
            GameObject deer = Instantiate(myPrefab, new Vector3(Random.Range(-9f, 9f), 0f, Random.Range(-9f, 9f)), Quaternion.AngleAxis(Random.Range(0, 360), transform.up));
            float scaleFactor = Random.Range(0.9f, 1.5f);
            deer.transform.localScale *= scaleFactor;
            timestamp = elapsedTime;
        }
    }
}
