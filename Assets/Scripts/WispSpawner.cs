using UnityEngine;
using UnityEngine.InputSystem;

public class WispSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wispPrefab;
    private GameObject wispInstance;

    // Update is called once per frame
    void Update()
    {
        if(Pointer.current != null && Pointer.current.press.wasPressedThisFrame && wispInstance == null)
        {
            Vector2 mousePosition = Pointer.current.position.ReadValue();
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            worldPosition.z = 0;
            wispInstance = Instantiate(wispPrefab, worldPosition, Quaternion.identity);
        }
    }
}
