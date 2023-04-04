using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Transform _turret;
    [SerializeField] private GameObject _firingPosition;
    [SerializeField] private GameObject _cannonBall;
    private Action<int> turretMovement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MoveUp(Action<Vector3> turretMovement)
    {

    }

    public void Fire()
    {
      Instantiate(_cannonBall, _firingPosition.transform.position,_firingPosition.transform.rotation);
    }
    public void MoveUp()
    {
        _turret.transform.Rotate(Vector3.right,1);
    }

    public void DownUp()
    {
        _turret.transform.Rotate(Vector3.right, -1);
    }

    public void RightUp()
    {
        _turret.transform.Rotate(Vector3.up, -1);
    }

    public void LeftUp()
    {
        _turret.transform.Rotate(Vector3.up, 1);
    }
}
