# C# Conditions and Loops

A quick reference guide for conditions and loops in C#.

## 📋 Index
- [A. While Loop](#a-while-loop)
- [B. Increment Operators](#b-increment-operators)
- [C. For Loop](#c-for-loop)
- [D. Loop Control Statements](#d-loop-control-statements)
- [E. Conditional Operator](#e-conditional-operator)
- [F. Infinite Loop](#f-infinite-loop)
- [G. Code Example](#g-code-example)
- [Best Practices](#best-practices)

## A. While Loop:

- **Purpose:** Repeatedly executes a block of code as long as a specified condition is true
- **Syntax:** `while (condition) { statements; }`
- **Evaluation:** Condition is evaluated before each iteration
- **Usage:** When the number of iterations is not known beforehand

## B. Increment Operators:

- **Postfix Increment (x++):**
  - First use the value, then increment
  - Example: In `while (x++ < 10)`, x is compared to 10, then incremented

- **Prefix Increment (++x):**
  - First increment the value, then use it
  - Example: In `while (++x < 10)`, x is incremented first, then compared to 10

## C. For Loop:

- **Purpose:** Repeatedly executes a block of code for a specified number of iterations
- **Standard Syntax:** `for (initializer; condition; iterator) { statements; }`
- **Components:**
  - **Initializer:** Executed before the loop begins (once)
  - **Condition:** Evaluated before each iteration
  - **Iterator:** Executed after each iteration
- **Note:** Semicolons are mandatory, even if components are omitted
- **Alternative Syntax:** `for (;;) { statements; }` (equivalent to infinite loop)

## D. Loop Control Statements:

- **break:**
  - **Purpose:** Exits the loop immediately
  - **Effect:** Control is transferred to the statement following the loop
  - **Usage:** When a certain condition is met and you need to terminate the loop

- **continue:**
  - **Purpose:** Skips the remaining statements in the current iteration
  - **Effect:** Control is transferred to the beginning of the next iteration
  - **Usage:** When you want to skip processing under certain conditions

## E. Conditional Operator:

- **Purpose:** A shorthand way to write if-else statements
- **Syntax:** `condition ? expressionIfTrue : expressionIfFalse`
- **Usage:** Assigning values based on a condition
- **Example:** `string result = (x > 5) ? "Greater" : "Less or Equal";`

## F. Infinite Loop:

- **Purpose:** A loop that runs indefinitely until explicitly terminated
- **Common Implementations:**
  - `while (true) { statements; }`
  - `for (;;) { statements; }`
- **Usage:** When the loop needs to run until an internal condition is met
- **Note:** Must include a way to exit (break statement or return) to avoid program freezing

## Best Practices 🥇

- Choose the appropriate loop type for your specific needs
  - `for` when the number of iterations is known
  - `while` or `do-while` when iterations depend on a condition
- Be careful with increment/decrement operators and understand their order of operations
- Always provide a way to exit infinite loops
- Use `break` and `continue` sparingly as they can make code harder to follow
- Prefer the conditional operator for simple if/else assignments
- Validate loop conditions to prevent infinite loops
- Consider readability when nesting loops and conditions
- Use meaningful variable names for loop counters when they rep