using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respuesta : MonoBehaviour
{
    public spawner spawner;
    private int rta;
    private int valor_correcto_rta;
    public InputField input_rta;
    public Button responder;
    public GameObject panel_rta;
    public GameObject panel_corr_inc;
    public Text txt_panel_corr_inc;
    public Text txt_btn_reiniciar_juego;
    public GameObject panel_no_rta;
    


    // Start is called before the first frame update
    void Start()
    {
        rta = int.Parse(input_rta.text);
        valor_correcto_rta = spawner.sumaPrecios;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void click_chek_rta()
    {
        if (input_rta.text == "")
        {
            panel_no_rta.SetActive(true);
        }
        else
        {
            panel_corr_inc.SetActive(true);
            if (rta == valor_correcto_rta)
            {
                txt_panel_corr_inc.text = "correcto";
                txt_btn_reiniciar_juego.text = "Reiniciar el desafio";

            }
            else
            {
                txt_panel_corr_inc.text = "incorrecto";
                txt_btn_reiniciar_juego.text = "Volver a intentarlo";
            }
        }
    }

    void click_cerrar_panel_no_rta()
    {
        input_rta.text = "";
        panel_no_rta.SetActive(false);
    }
}
