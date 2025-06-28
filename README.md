# 🎓 Student Score Evaluator – C# Console App

This is a simple C# console application that accepts student names and scores with conditions:
- If the score is **zero**, the student is skipped.
- If the score is **negative**, the program stops reading further input.
- Only valid scores (greater than 0) are counted for average computation.

## 📋 Program Description

The program:
1. Asks how many students you want to input (between 1 to 10).
2. Takes the name and score of each student.
3. Applies the following logic:
   - If score is `0`: skip and move to the next.
   - If score is `< 0`: stop input immediately.
4. Calculates the **total number of students with valid scores** and **average score**.
5. Displays the results with **2 decimal places**.

---

## 🧪 Sample Output


```text
How many students you have (1-10)? 3

Enter Name of Student 1: Alice
Enter Alice's Score: 90

Enter Name of Student 2: Joshua
Enter Joshua's Score: 0
Score is Zero(0). Skipped.

Enter Name of Student 3: Mark
Enter Mark's Score: -100
Score is Negative. Stop.

Total Number of Students with valid Score: 1
Average Score: 90.00
