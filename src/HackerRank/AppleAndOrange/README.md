# Problem Apple and Orange

Sam's house has an apple tree and an orange tree that yield an abundance of fruit. Using the information given below, determine the number of apples and oranges that land on Sam's house.

In the diagram below:

- The red region denotes the house, where <b>s</b> is the start point, and <b>t</b> is the endpoint. The apple tree is to the left of the house, and the orange tree is to its right.

- Assume the trees are located on a single point, where the apple tree is at point <b>a</b>, and the orange tree is at point <b>b</b>.

- When a fruit falls from its tree, it lands <b>d</b> units of distance from its tree of origin along the <b>x</b>-axis. *A negative value of <b>d</b> means the fruit fell <b>d</b> units to the tree's left, and a positive value of <b>d</b> means it falls <b>d</b> units to the tree's right. *

Given the value of <b>d</b> for <b>m</b> apples and <b>n</b> oranges, determine how many apples and oranges will fall on Sam's house (i.e., in the inclusive range <b>[s,t]</b>)?

For example, Sam's house is between <b>s = 7</b> and <b>t = 10</b>. The apple tree is located at <b>a = 4</b> and the orange at <b>b = 12</b>. There are <b>m = 3</b> apples and <b>n = 3</b> oranges. Apples are thrown <b>apples = [2, 3, -4]</b> units distance from <b>a</b>, and <b>oranges = [3, -2, -4]</b> units distance. Adding each apple distance to the position of the tree, they land at <b>[4 + 2, 4 + 3, 4 + -4] = [6, 7, 0]</b>.

Oranges land at <b>[12 + 3, 12 + -2, 12 + -4] = [15, 10, 8]</b>. One apple and two oranges land in the inclusive range <b>7 - 10</b> so we print

```bash
1
2
```

## Function Description

Complete the countApplesAndOranges function in the editor below. It should print the number of apples and oranges that land on Sam's house, each on a separate line.

countApplesAndOranges has the following parameter(s):

- s: integer, starting point of Sam's house location.
- t: integer, ending location of Sam's house location.
- a: integer, location of the Apple tree.
- b: integer, location of the Orange tree.
- apples: integer array, distances at which each apple falls from the tree.
- oranges: integer array, distances at which each orange falls from the tree.

## Input Format

The first line contains two space-separated integers denoting the respective values of <b>s</b> and <b>t</b>.
The second line contains two space-separated integers denoting the respective values of <b>a</b> and <b>b</b>.
The third line contains two space-separated integers denoting the respective values of <b>m</b> and <b>n</b>.
The fourth line contains <b>m</b> space-separated integers denoting the respective distances that each apple falls from point <b>a</b>.
The fifth line contains <b>n</b> space-separated integers denoting the respective distances that each orange falls from point <b>b</b>.

## Constraints
<b>
1 <= s,t,a,b,m,n <= 10^5

-10^5 <= d <= 10^5

a < s < t < b
</b>

## Output Format

Print two integers on two different lines:

 1. The first integer: the number of apples that fall on Sam's house.

 2. The second integer: the number of oranges that fall on Sam's house.

## Sample Input
```bash
7 11
5 15
3 2
-2 2 1
5 -6
```

## Sample Output
```bash
1
1
```

## Explanation
The first apple falls at position <b>5 - 2 = 3</b>.

The second apple falls at position <b>5 + 2 = 7</b>.

The third apple falls at position <b>5 + 1 = 6</b>.

The first orange falls at position <b>15 + 5 = 20</b>.

The second orange falls at position <b>15 - 6 = 9</b>.

Only one fruit (the second apple) falls within the region between <b>7</b> and <b>11</b>, so we print <b>1</b> as our first line of output.

Only the second orange falls within the region between <b>7</b> and <b>11</b>, so we print <b>1</b> as our second line of output.

## Answer 
```cs
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

class Result
{

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void CountApplesAndOranges(int houseStartingLocationPoint,
                                             int houseEndingLocationPoint, 
                                             int appleTreeLocation, 
                                             int orangeTreeLocation, 
                                             List<int> applesFallDistances, 
                                             List<int> orangesFallDistances)

    {
        int applesAtHouse = 0, orangesAtHouse = 0;

        foreach (var apple in applesFallDistances)
            if (apple + appleTreeLocation >= houseStartingLocationPoint && apple + appleTreeLocation <= houseEndingLocationPoint)
                applesAtHouse++;

        foreach (var orange in orangesFallDistances)
            if (orange + orangeTreeLocation >= houseStartingLocationPoint && orange + orangeTreeLocation <= houseEndingLocationPoint)
                orangesAtHouse++;

        Console.WriteLine($"{applesAtHouse}\n{orangesAtHouse}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.CountApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
```