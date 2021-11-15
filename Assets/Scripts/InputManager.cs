using UnityEngine;
namespace SpaceShooter
{
    //Получет информацию о вводе
    internal static class InputManager
    {
        internal static float Vertical { get; private set; }
        internal static float Horizontal { get; private set; }
        internal static bool FireButtonDown { get; private set; }
        internal static void GetAllInput()
        {
            Horizontal = Input.GetAxis("Horizontal");
            Vertical = Input.GetAxis("Vertical");

            if (Input.GetButtonDown("Fire1")) FireButtonDown = true;
            else FireButtonDown = false;
        }
    }
}