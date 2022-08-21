# Problem Fair Rations
You are the benevolent ruler of Rankhacker Castle, and today you're distributing bread. Your subjects are in a line, and some of them already have some loaves. Times are hard and your castle's food stocks are dwindling, so you must distribute as few loaves as possible according to the following rules:

1. Every time you give a loaf of bread to some person , you must also give a loaf of bread to the person immediately in front of or behind them in the line (i.e., persons  or ).

2. After all the bread is distributed, each person must have an even number of loaves.

Given the number of loaves already held by each citizen, find and print the minimum number of loaves you must distribute to satisfy the two rules above. If this is not possible, print NO.

## Example

<b>B = [4. 5. 6. 7]</b>
- We can first give a loaf to  and  so .
- Next we give a loaf to  and  and have  which satisfies our conditions.

All of the counts are now even numbers. We had to distribute <b>4</b> loaves.

## Function Description

Complete the fairRations function in the editor below.

fairRations has the following parameter(s):

- int B[N]: the numbers of loaves each persons starts with

## Returns

- string: the minimum number of loaves required, cast as a string, or 'NO'

## Input Format

The first line contains an integer <b>N</b>, the number of subjects in the bread line.

The second line contains <b>N</b> space-separated integers <b>B[i]</b>.

## Constraints
<b>
- 2 <= N <= 1000
- 1 <= B[i] <= 10, where 1 <= i <= N
</b>

## Sample Input 0
```bash
STDIN       Function
-----       --------
5           B[] size N = 5
2 3 4 5 6   B = [2, 3, 4, 5, 6]   
```

## Sample Output 0
```bash
4
```

## Explanation 0
The initial distribution is  <b>(2, 3, 4, 5, 6)</b>. The requirements can be met as follows:

1. Give 1 loaf of bread each to the second and third people so that the distribution becomes (2, 4, 5, 5, 6).

2. Give 1 loaf of bread each to the third and fourth people so that the distribution becomes (2, 4, 6, 6, 6).

Each of the <b>N</b> subjects has an even number of loaves after  loaves were distributed.


## Sample Input 1
```bash
2
1 2
```

## Sample Output 1
```bash
NO
```

## Explanation 1
The initial distribution is <b>(1, 2)</b>. As there are only  people in the line, any time you give one person a loaf you must always give the other person a loaf. 
Because the first person has an odd number of loaves and the second person has an even number of loaves, no amount of distributed loaves will ever result in both subjects having an even number of loaves.

## Answer 
```cs

```