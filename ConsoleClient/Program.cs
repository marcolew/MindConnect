﻿using System;
using MindConnect;
using MindConnect.Model;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mappings m = new Mappings();
            PagedMapping pagedMapping = m.DataPointMappingsGet(string.Empty,null,null,string.Empty);
        }
    }
}
