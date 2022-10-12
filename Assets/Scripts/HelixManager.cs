using UnityEngine;

public class HelixManager : MonoBehaviour
{
    public GameObject[] helixRings;
    public float ySpawn = 0;
    public float ringsDistance = 5;

    public int numberOfRings;
    public GameObject lastRing;

    void Start()
    {
        numberOfRings = GameManager.currentLevelIndex + 30;
        // spawn helix rings
        for(int i=0; i< numberOfRings; i++)
        {
            if (i == 0)
                SpawnRing(0);
            else
            SpawnRing(Random.Range(0, helixRings.Length - 1));
        }

        // spawn the last ring
        SpawnRing(helixRings.Length - 1);
    }

    public void SpawnRing(int ringIndex)
    {
        GameObject go = Instantiate(helixRings[ringIndex], transform.up * ySpawn, Quaternion.identity);
        go.transform.parent = transform;
        ySpawn -= ringsDistance;
    }
}

