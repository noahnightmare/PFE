using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug {  get; set; } = false;

        [Description("Fuse time for grenades")]
        public float FuseTime { get; set; } = 0.5f;

        [Description("How many grenades should be spawned")]
        public int Grenades { get; set; } = 1;
    }
}
