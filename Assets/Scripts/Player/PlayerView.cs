using UnityEngine;
namespace SpaceShooter
{
    /// <summary>
    /// Общается с компонентами Unity, размещенными на игроке
    /// </summary>
    [RequireComponent(typeof(Transform))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    internal sealed class PlayerView : MonoBehaviour
    {
        internal Rigidbody2D Rigidbody2D { get; private set;}
        internal Transform Transform { get; private set; }
        void Awake()
        {
            Rigidbody2D = GetComponent<Rigidbody2D>();
            Transform = GetComponent<Transform>();
        }
    }
}
