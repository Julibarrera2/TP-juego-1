using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] objetos;
    public Transform spawnpoint1;
    public Transform spawnpoint2;

    void Start()
    {
        int Idx_Obj1 = Random.Range(1,objetos.Length);
        int Idx_Obj2 = Random.Range(1,objetos.Length);

        crear_objeto(objetos[Idx_Obj1],spawnpoint1.position,spawnpoint1.rotation);
        crear_objeto(objetos[Idx_Obj2], spawnpoint2.position, spawnpoint2.rotation);
    }
    void Update()
    {
        
    }

    void crear_objeto (GameObject objeto, Vector3 position, Quaternion rotation)
    {
        Instantiate(objeto, position, rotation);
    }
}
