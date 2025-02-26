using UnityEngine;

namespace Source.Script.Game
{
    public class MovingObjects : MonoBehaviour
    {
        private Rigidbody _rb;
        private HingeJoint _joint;

        public void Initialize()
        {
            _rb = gameObject.AddComponent<Rigidbody>();
            _joint = gameObject.AddComponent<HingeJoint>();
        
            JointMotor motor = _joint.motor;
            motor.targetVelocity = 50f;  // Скорость мотора
            motor.force = 10f;  // Максимальный крутящий момент
            _joint.motor = motor;
            _joint.useMotor = true;
        }
    }
}