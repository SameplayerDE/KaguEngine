﻿using System;

namespace Test
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var game = new Game0();
            game.Run();
        }
    }
}