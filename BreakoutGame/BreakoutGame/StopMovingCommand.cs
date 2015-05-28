﻿using Mabv.Breakout.GameEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mabv.Breakout
{
    public class StopMovingCommand : ICommand
    {
        private Paddle paddle;

        public StopMovingCommand(Paddle paddle)
        {
            this.paddle = paddle;
        }

        public void Execute()
        {
            paddle.StopMoving();
        }
    }
}
