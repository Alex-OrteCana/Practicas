using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void CargarMenu()
    {
        SceneManager.LoadScene("InicioSesion"); // Aseg�rate de que este es el nombre de tu escena de men� principal
    }
}
