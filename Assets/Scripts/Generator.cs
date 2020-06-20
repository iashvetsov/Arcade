using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> prefabLibrary;
    //coordinate X range
    public float minX, maxX;

    //Start
    private void Start() {
        //Generate the first object
        Generate();
    }

    //Generate random prefab frol library
    public void Generate()
    {
        //Instantiate random item from library
        GameObject prefab = Instantiate(prefabLibrary[Random.Range(0, prefabLibrary.Count)], transform);
        float x = Random.Range(minX, maxX);
        prefab.transform.position = new Vector3(x, prefab.transform.position.y, prefab.transform.position.z);
    }
}
