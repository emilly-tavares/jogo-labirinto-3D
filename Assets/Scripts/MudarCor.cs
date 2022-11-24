using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCor : MonoBehaviour
{
    //Array de cor (lista)
    public Color[] cores;

    //Para acessar o material do objeto
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        //Adiciona "c" na Array cor 
        //O valor de c (a cor de c) vai ser entre 0 e todas as outras cores 
        //Subtrai por 1 pois Legth é o tamanho da array, e o tamanho da array é maior em 1 no valor nos números

        Color c = cores[Random.Range(0, cores.Length - 1)];

        //Pegar o componente Renderer e acessar a cor do material para modificar para a escolhida 
        GetComponent<Renderer>().material.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
