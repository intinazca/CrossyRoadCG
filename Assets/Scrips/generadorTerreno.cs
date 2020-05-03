using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorTerreno : MonoBehaviour
{  
     [SerializeField] private int maxTerrainCount;
      //creamos una lista que va almacenar objetos del juego que son las partes del terreno
    [SerializeField] private  List<GameObject> terrains = new List<GameObject>();
     //creamos un objeto de tipo vector que inicia en la posicion 0,0,0
    private Vector3 currentPosition= new Vector3(0,0,0);
   

    void Start()
    {
       //usamos el for para recorrer el array del contador de terreno maximo
      for (int i = 0; i <maxTerrainCount; i++)
      {
           SpawnTerrain();
      }
      
    }
  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
          SpawnTerrain();
        }
    }

    private void SpawnTerrain()
    {
        //  instaciamos el terrenoo y lo generamos de manera ramdom en un rango determinado
            Instantiate(terrains[Random.Range(0, terrains.Count)], currentPosition, Quaternion.identity);
            currentPosition.x++;
    }
}
