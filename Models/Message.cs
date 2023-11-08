﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluster_Procesamiento.Models
{
    public class Message
    {
        public MessageType Type { get; set; }
        public object? Content { get; set; }
        public Connection? connection { get; set; }
    }
}
