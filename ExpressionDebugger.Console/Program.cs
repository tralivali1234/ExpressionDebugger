﻿using ExpressionDebugger;
using System;
using System.Linq.Expressions;

namespace ExpressionDebugger.Console {
    class Program {
        static void Main(string[] args) {
            var p1 = Expression.Parameter(typeof(int));
            var p2 = Expression.Parameter(typeof(int));
            var body = Expression.Add(p1, p2);
            var lambda = Expression.Lambda<Func<int, int, int>>(body, p1, p2);
            var fun = lambda.CompileWithDebugInfo();
            var result = fun(1, 2);
            System.Console.WriteLine(3);
        }
    }
}