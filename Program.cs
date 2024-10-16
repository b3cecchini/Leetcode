﻿using Leetcode.Problems;
using Leetcode.Utils;

/*
var root = new TreeNode(0);
var node1 = new TreeNode(1);
var node2 = new TreeNode(2);    
var node3 = new TreeNode(3);
var node4 = new TreeNode(4);
var node5 = new TreeNode(5);
var node6 = new TreeNode(6);
/*
 *       0
 *     /   \ 
 *    1     2 
 *   / \     \
 *  3   4     5
 *           /
 *          6
 */
/*
root.left = node1;
root.right = node2;
node1.left = node3;
node1.right = node4;
node2.right = node5;
node5.left = node6;



var problem = new Fiddle();
var ans = problem.DepthFirst_WithStack(root);

Console.WriteLine("Depth first with Stack");
for (int i = 0; i < ans.Count; i++)
{
    Console.WriteLine(ans[i]);
}
Console.WriteLine("\r\n+++++++++++++++");
Console.WriteLine("Depth first with Recursion");

problem.DepthFirstSearch(root);

for (int i = 0; i < problem.answer.Count; i++)
{
    Console.WriteLine(problem.answer[i]);
}

Console.WriteLine("\r\n+++++++++++++++");
Console.WriteLine("Breadth first with Queue");
var a = problem.BreathFirst_WithQueue(root);
for (int i = 0; i < a.Count; i++)
{
    Console.WriteLine(a[i]);
}
var t1 = 3;
var a1 = problem.TreeIncludes_Recursive(root, t1);
var t2 = 6;
var a2 = problem.TreeIncludes_Recursive(root, t2);
var t3 = 9;
var a3 = problem.TreeIncludes_Recursive(root, t3);

Console.WriteLine("Is " + t1.ToString() + " in the tree? - " + a1.ToString());
Console.WriteLine("Is " + t2.ToString() + " in the tree? - " + a2.ToString());
Console.WriteLine("Is " + t3.ToString() + " in the tree? - " + a3.ToString());


Console.WriteLine("TreeSum is - " + problem.TreeSum_Recursive(root));

Console.WriteLine("TreeSum_Itterative is - " + problem.TreeSum_Itterative(root));

Console.WriteLine("Min Value is - " + problem.TreeMin_Itterative(root));


Console.WriteLine("Min Value(Recursion) is - " + problem.TreeMin_Recursive(root));

Console.WriteLine("Max Sum(Recursion) is - " + problem.TreeMaxSum_Recursive(root));
*/




//head = [1,2,3,4,5]

/*
ListNode head = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(3);
ListNode node4 = new ListNode(4);
ListNode node5 = new ListNode(5);

head.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;

var problem = new _206();

problem.ReverseList(head);


string[] tokens = { "4", "13", "5", "/", "+" };

var problem = new _150();

problem.EvalRPN(tokens);
*/

/*
var root = new TreeNode(5);
var node4 = new TreeNode(4);
var node11 = new TreeNode(11);
var node7 = new TreeNode(7);
var node2 = new TreeNode(2);
var node8 = new TreeNode(8);
var node13 = new TreeNode(13);
var node4_r = new TreeNode(4);
var node1 = new TreeNode(1);
/*
 *        5
 *      /   \ 
 *     4     8 
 *    /     / \
 *   11    13  4
 *  / \         \
 * 7   2         1
 *
 *
 *
 
root.left = node4;
root.right = node8;

node4.left = node11;

node11.left = node7;
node11.right = node2;

node8.left = node13;
node8.right = node4_r;

node4_r.right = node1;

var problem = new _112();

problem.HasPathSum(root, 22);


/*
var problem = new _1684();

var allowed = "cad";
string[] words = ["cc", "acd", "b", "ba", "bac", "bad", "ac", "d"];


var answer = problem.CountConsistentStrings(allowed, words);
Console.WriteLine("*********************");
Console.WriteLine($"Answer: {answer}");


var problem = new _232();


for (int i = 1; i < 5; i++)
{
    problem.Push(i);
}

problem.PrintMain();

Console.WriteLine("***********************");
Console.WriteLine("Peek " + problem.Peek().ToString());

Console.WriteLine("***********************");
Console.WriteLine("Pop " + problem.Pop().ToString());

Console.WriteLine("***********************");
problem.PrintMain();

var problem = new _643();

problem.FindMaxAverage([1, 12, -5, -6, 50, 3], 4);


var problem = new _1207();

problem.UniqueOccurrences([1, 7, 3, 6, 5, 6]);
*/

var problem = new _98();

var root = new TreeNode(5);
var node1 = new TreeNode(1);
var node4 = new TreeNode(4);
var node3 = new TreeNode(3);
var node6 = new TreeNode(6);

root.left = node1;
root.right = node4;

node4.left = node3;
node4.right = node6;

Console.WriteLine(problem.IsValidBST(root));








