using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CaruselController : MonoBehaviour
{
    #region Editor

    [SerializeField]
    private Transform _selfTransform;

    [SerializeField]
    private FixedJoystick _joyStick;

    [SerializeField]
    private float _rotationSpeed;

    [SerializeField]
    private float _joyStickBoundry;

    #endregion

    #region Methods

    private void FixedUpdate()
    {
        CaruselRotation();
    }

    private void CaruselRotation()
    {
        if (_joyStick.Horizontal > _joyStickBoundry)
        {
            var temp = _joyStick.Horizontal;
            _selfTransform.Rotate(0, 0, -temp * _rotationSpeed * Time.deltaTime);
        }
        else if (_joyStick.Horizontal < -_joyStickBoundry)
        {
            var temp = _joyStick.Horizontal;
            _selfTransform.Rotate(0, 0, -temp * _rotationSpeed * Time.deltaTime);
        }
    }

    #endregion
}
