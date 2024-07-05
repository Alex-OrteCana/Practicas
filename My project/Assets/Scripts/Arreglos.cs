using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Arreglos : MonoBehaviour
{
    public GameObject panelAlertas;
    public string[] textoAlertas;
    public GameObject menuSeleccion; // Nuevo GameObject para el menú de selección
    public GameObject panelAcceder; // GameObject para el panel de acceso
    public GameObject panelNuevoUsuario; // GameObject para el panel de nuevo usuario

    public List<string> usuarios = new List<string>();

    public TMP_InputField nombreUsuario;
    public TMP_InputField nombreNuevoUsuario;
    public TMP_Text alertasDisplay;

    void Start()
    {
        usuarios.Add(item: "Alex");
        usuarios.Add(item: "Vane");
        usuarios.Add(item: "Fany");

        // Asegurarse de que el menú de selección y el panel de alertas estén desactivados al inicio
        if (menuSeleccion != null)
        {
            menuSeleccion.SetActive(false);
        }
        if (panelAlertas != null)
        {
            panelAlertas.SetActive(false);
        }
    }

    public void AccederConUsuario()
    {
        if (usuarios.Contains(nombreUsuario.text))
        {
            // Mostrar el menú de selección y ocultar el panel de acceso
            if (menuSeleccion != null)
            {
                menuSeleccion.SetActive(true);
            }
            if (panelAcceder != null)
            {
                panelAcceder.SetActive(false);
            }
            if (panelAlertas != null)
            {
                panelAlertas.SetActive(false);
            }
        }
        else
        {
            if (panelAlertas != null)
            {
                panelAlertas.SetActive(true);
                alertasDisplay.text = textoAlertas[1];
            }
        }
    }

    public void CrearUsuario()
    {
        if (usuarios.Contains(nombreNuevoUsuario.text))
        {
            if (panelAlertas != null)
            {
                panelAlertas.SetActive(true);
                alertasDisplay.text = textoAlertas[2];
            }
        }
        else
        {
            usuarios.Add(nombreNuevoUsuario.text);
            if (panelAlertas != null)
            {
                panelAlertas.SetActive(true);
                alertasDisplay.text = textoAlertas[3];
            }
        }
    }

    // Nuevas funciones para cargar escenas
    public void CargarAudioPlayer()
    {
        SceneManager.LoadScene("AudioPlayer");
    }

    public void CargarSelector()
    {
        SceneManager.LoadScene("Selector");
    }
}
