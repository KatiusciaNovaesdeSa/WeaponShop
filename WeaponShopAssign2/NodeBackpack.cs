using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class NodeBackpack
    {
        public Weapon data;
        public NodeBackpack next;

        public NodeBackpack(Weapon data)
        {
            this.data = data;
            next = null;
        }
    }
}
