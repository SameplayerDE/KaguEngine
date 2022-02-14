using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace KaguEngine.Input
{
    public class InputAction
    {
        public List<Keys> Keys;
        public InputActionTrigger InputActionTrigger;
        public bool IsTriggered;
    }
}