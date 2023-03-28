using UnityEngine;

public class UIMiniMap : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] Transform _enemey;
    [SerializeField] RectTransform _map;
    [SerializeField] RectTransform _Enemy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _map.transform.localPosition = new Vector3(-1 * (_player.position.x), -1 * (_player.position.z), 0);
        _Enemy.transform.localPosition = new Vector3(-1 * (_enemey.position.x), -1 * (_enemey.position.z), 0);
    }
}
