# 🔴⚫ Red-Black Tree in C#

## Overview

This project demonstrates the implementation of a **Red-Black Tree** in C#.
A Red-Black Tree is a type of **self-balancing binary search tree (BST)** that maintains balance by enforcing a set of color and rotation rules. This ensures that common operations such as insertion, search, and deletion all take **O(log n)** time.

---

## Features

* Insert integers into the Red-Black Tree.
* Automatic rebalancing using **rotations** and **color flipping**.
* In-order traversal displaying node values with their colors (R = Red, B = Black).
* Simple console-based demonstration.

---

## How It Works

Each node in the tree is either **red** or **black**.
After every insertion:

1. The tree ensures no two consecutive red nodes exist.
2. The root node is always black.
3. Every path from the root to a leaf has the same number of black nodes.

Balancing is achieved using:

* **Left and Right rotations**
* **Recoloring** (changing node colors to maintain Red-Black properties)

---

## Example Output

When inserting the values:

```
10, 20, 30, 15, 25, 5, 1
```

The console displays:

```
In-order traversal with colors:
1(R) 5(B) 10(R) 15(B) 20(B) 25(R) 30(B)
```

This shows the balanced Red-Black structure after all rotations and recolorings.

---

## Project Structure

```
RedBlackTree/
│
├── Node.cs              # Defines the Node class with color, parent, left/right children
├── RedBlackTree.cs      # Contains insertion logic, rotations, and balancing
├── Program.cs           # Console entry point that demonstrates insertion and traversal
└── README.md            # Project description (this file)
```

---

## How to Run

1. Open the folder in Visual Studio Code or Visual Studio.
2. Run the following command in the terminal:

   ```bash
   dotnet run
   ```
3. The program will insert sample values and print the tree traversal to the console.

---

## Complexity

| Operation | Average Case | Worst Case |
| --------- | ------------ | ---------- |
| Search    | O(log n)     | O(log n)   |
| Insert    | O(log n)     | O(log n)   |
| Delete    | O(log n)     | O(log n)   |

---

## Author

**Michael Singh**
Developed as part of a learning exercise to understand tree data structures and balancing algorithms in C#.
