﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ExpressionDebugger
{
    public class ExpressionCompilationOptions
    {
        public ExpressionDefinitions DefaultDefinitions { get; set; }
        public IEnumerable<Assembly> References { get; set; }
        public bool EmitFile { get; set; }
        public string RootPath { get; set; }
        public bool IsRelease { get; set; }
    }
}