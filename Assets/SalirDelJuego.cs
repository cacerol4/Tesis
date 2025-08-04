using UnityEngine;

public class SalirDelJuego : MonoBehaviour
{
    public void Salir()
    {
        // Esto funciona en una build (EXE, APK, etc.)
        Application.Quit();

        // Esto es solo para que veas que el botón funciona mientras estás en el editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
