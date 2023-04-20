using UnityEngine;

public class PauseFunction : MonoBehaviour
{
    private void OnEnable() {
        Time.timeScale = 0.0f;
    }

    private void OnDisable() {
        Time.timeScale = 1.0f;
    }
}
