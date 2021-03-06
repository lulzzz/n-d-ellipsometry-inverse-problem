﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphics
{
    public abstract class AbstractCharting
    {
        public abstract void Init();
        public abstract void ChangeState(params object[] args);
        public abstract void Draw();
    }
}
