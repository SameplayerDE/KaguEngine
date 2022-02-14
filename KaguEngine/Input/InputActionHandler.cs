using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;

namespace KaguEngine.Input
{
    public sealed class InputActionHandler<T> where T : Enum
    {
        private Dictionary<T, InputAction> _inputActions;

        public void MapInputAction(T value, InputAction inputAction)
        {
            _inputActions[value] = inputAction;
        }
        
        public bool IsInputActionTriggered(T value)
        {
            return _inputActions.ContainsKey(value) && _inputActions[value].IsTriggered;
        }

        public void Update(GameTime gameTime)
        {
            
        }
        
    }
}