using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] objetos;
    public Transform spawnpoint1;
    public Transform spawnpoint2;
    public int sumaPrecios;

    void Start()
    {
        int Idx_Obj1 = Random.Range(0,objetos.Length);
        int Idx_Obj2 = Random.Range(0,objetos.Length);

        GameObject obj1 = crear_objeto(objetos[Idx_Obj1], spawnpoint1.position, spawnpoint1.rotation);
        GameObject obj2 = crear_objeto(objetos[Idx_Obj2], spawnpoint2.position, spawnpoint2.rotation);

        Product producto1 = obj1.GetComponent<Product>();
        Product producto2 = obj2.GetComponent<Product>();

        sumaPrecios = producto1.precio + producto2.precio;
        Debug.Log("Suma de precios: " + sumaPrecios);
    }
    void Update()
    {
        
    }

    GameObject crear_objeto (GameObject objeto, Vector3 position, Quaternion rotation)
    {
        return Instantiate(objeto, position, rotation);
    }
}
