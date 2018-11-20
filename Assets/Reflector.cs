using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Reflections
{
    public interface Target
    {
        void OnMouseDown();
    }

    public class Reflector : MonoBehaviour
    {
        public Target parent;
        private void OnMouseDown()
        {
            print("mouse down on child object");
            parent.OnMouseDown();
        }
    }
}

