﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CustomDoublyLinkedList
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
}
