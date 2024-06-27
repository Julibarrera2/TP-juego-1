using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respuesta : MonoBehaviour
{
    public spawner spawner;
    private int rta_valor;
    private int rta;
    public InputField input_rta;
    public Button responder;
    public Text txt_btn_rta;


    // Start is called before the first frame update
    void Start()
    {
        rta_valor = int.Parse(input_rta.text);
        rta = spawner.sumaPrecios;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void chek_rta()
    {
        if(rta_valor == rta)
        {

        }
    }
}
