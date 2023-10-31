﻿/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");

        // Defect(s) Found:

        priorityQueue.Enqueue(" Item 1", 1);
        priorityQueue.Enqueue(" Item 2", 2);
        priorityQueue.Enqueue(" Item 3", 3);

        Console.WriteLine("Dequeue Result 1" + priorityQueue.Dequeue());
        Console.WriteLine("Dequeue Result 2" + priorityQueue.Dequeue());
        Console.WriteLine("Dequeue Result 3" + priorityQueue.Dequeue());

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        priorityQueue.Enqueue(" Item 1", 2);
        priorityQueue.Enqueue(" Item 2", 2);

        Console.WriteLine("Dequeue Result 1" + priorityQueue.Dequeue());
        Console.WriteLine("Dequeue Result 2" + priorityQueue.Dequeue());

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}