using UnityEngine;

public class SpawnGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnRandom()
    {
        Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere), new Vector3(Random.Range(0, 5), 0, Random.Range(0, 5)), Quaternion.identity);
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
    }
}
