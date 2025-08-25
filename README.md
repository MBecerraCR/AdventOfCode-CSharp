# Advent of Code 2023 - C# Solutions

This repository documents my progress and solutions for the [Advent of Code 2023](https://adventofcode.com/2023) challenges, solved using the C# programming language.

The goal is to practice my programming and algorithm skills while applying best practices for coding and version control with Git.

---

### Solutions by Day

Here you will find a summary of the solutions for each completed challenge.

#### Day 1: Sonar Sweep
* **Problem Statement:** [View on Advent of Code](https://adventofcode.com/2023/day/1)
* **Solution Description:**
    * **Part 1:** The challenge involves counting the number of times a depth measurement (or the sum of a three-measurement sliding window) increases from the previous one. The solution iterates through the array once.
    * **Part 2:** An optimized solution is used to count the number of times the sum of a three-measurement sliding window increases. Instead of calculating each full window sum, the solution compares the new measurement entering the window with the one leaving it, simplifying the logic (`measurements[i] > measurements[i-3]`).

---
