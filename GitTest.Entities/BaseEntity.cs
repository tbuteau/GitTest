﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace GitTest.Entities
{
    public class BaseEntity
    {
        public string Id { get;set;}
        public string Name { get; set; }

        public Dictionary<string, string> ExtraData { get; set; }

    }
}
