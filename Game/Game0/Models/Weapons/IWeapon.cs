﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    public interface IWeapon
    {
        int Damage
        {
            get;
        }
        void Use(Mob mob);
    }

}
