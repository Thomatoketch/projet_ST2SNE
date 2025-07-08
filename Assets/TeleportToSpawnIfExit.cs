using UnityEngine;

public class TeleportToSpawnIfExit : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _spawnPoint;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _player)
        {
            _player.transform.position = _spawnPoint.position;
            _player.transform.rotation = _spawnPoint.rotation;
        }
    }
}
