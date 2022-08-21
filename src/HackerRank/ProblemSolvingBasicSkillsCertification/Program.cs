using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

int sidesRows = Convert.ToInt32(Console.ReadLine().Trim());
int sidesColumns = Convert.ToInt32(Console.ReadLine().Trim());

List<List<long>> sides = new List<List<long>>();

for (int i = 0; i < sidesRows; i++)
{
    sides.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sidesTemp => Convert.ToInt64(sidesTemp)).ToList());
}

long result = nearlySimilarRectangles(sides);

Console.WriteLine(result);


static long nearlySimilarRectangles(List<List<long>> sides)
{
    var results = new List<double>();
    long nearlySimilarResultCount = 0;

    foreach (var side in sides)
    {
        double result = (double)side[0] / side[1];

        Console.WriteLine($"{side[0]} / {side[1]} = {result}");

        results.Add(Math.Round(result, 2 ));
    }

    var distinctResults = results.Distinct().ToList();

    Console.WriteLine($"Distinct results count = {distinctResults.Count}");

    foreach (var result in distinctResults)
    {
        var nearlySimilarCount = results.Where(c => c == result).Count();

        if (nearlySimilarCount > 1)
        {
            nearlySimilarResultCount += distinctResults.Count == 1 ? 1 : --nearlySimilarCount;

            Console.WriteLine($"Distinct result: {nearlySimilarCount}");
        }
    }

    return nearlySimilarResultCount;
}