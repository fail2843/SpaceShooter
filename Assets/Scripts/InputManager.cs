using UnityEngine;
namespace SpaceShooter
{
    internal sealed class InputManager
    {
        internal float vertical;
        internal float horizontal;
        internal bool fireButtonDown;
        internal void GetAllInput()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            if (Input.GetButtonDown("Fire1")) fireButtonDown = true;
            else fireButtonDown = false;
        }
    }
}