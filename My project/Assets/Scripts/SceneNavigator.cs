using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void CargarMenu()
    {
        SceneManager.LoadScene("InicioSesion"); // Asegúrate de que este es el nombre de tu escena de menú principal
    }
}
