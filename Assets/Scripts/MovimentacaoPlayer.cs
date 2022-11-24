using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPlayer : MonoBehaviour
{
    float velocidade;
    public Vector3 mov;
    private Animator animator;
    
    //float velocidadeGirar;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        velocidade = 8.0f;
        //velocidadeGirar = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // float translate = (Input.GetAxisRaw("Vertical") * velocidade) * Time.deltaTime;
        // float rotate = (Input.GetAxisRaw("Horizontal") * velocidadeGirar) * Time.deltaTime;

        //transform.Translate(0, 0, translate);
        //transform.Rotate(0, rotate, 0);

        mov = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * velocidade * Time.deltaTime;
       

        transform.Translate(mov);

       
        if(mov == Vector3.zero)
        {
            animator.SetBool("andando", false);
        }
        else
        {
            animator.SetBool("andando", true);

        }
    }
}
