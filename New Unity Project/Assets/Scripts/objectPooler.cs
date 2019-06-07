using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPooler : MonoBehaviour
{
    [System.Serializable] //This will make it appear on Unity
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    #region Singleton

    public static objectPooler Instace;

    private void Awake()
    {
        Instace = this;
    }

    #endregion

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    
    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach(Pool pool in pools) //For each pool of objects
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for(int i = 0; i < pool.size; i++) //loop thru all objects in the pool
            {
                GameObject obj = Instantiate(pool.prefab); //create the object according to the given prefab
                obj.SetActive(false);  //disable it so it's not visible just yet
                objectPool.Enqueue(obj); //add it to the queue
            }

            poolDictionary.Add(pool.tag, objectPool); //add queue to the dictionary pf pools
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {

        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag " + tag + " doesn't exist.");
            return null;
        }
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();
        Rigidbody rb = objectToSpawn.GetComponent<Rigidbody>();

        rb.angularVelocity = Vector3.zero; //Stop angular momentum before respawn
        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;
        
        poolDictionary[tag].Enqueue(objectToSpawn); //back to the queue
        return objectToSpawn;
    }

}
