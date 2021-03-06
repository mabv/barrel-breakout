﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mabv.Breakout.Collisions
{
    public class Collision : ICollision
    {
        private ICollider incomingCollider;
        public ICollider Collider {
            get { return incomingCollider; }
        }
        private ICollider reactingCollider;
        public ICollider ReactingCollider
        {
            get { return reactingCollider;  }
        }
        public Vector2 Overlap { get { return overlap; } }
        // public IGameEntity attachedGameEntity;
        private Vector2 overlap;

        public Collision(ICollider incomingCollider, Vector2 overlap, ICollider reactingCollider)
        {
            this.incomingCollider = incomingCollider;
            this.overlap = overlap;
            this.reactingCollider = reactingCollider;
        }
    }
}
