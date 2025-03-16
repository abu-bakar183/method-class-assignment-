# C# Console Application - Math Operations  

## **Description**  
This is a simple C# console application that demonstrates:  
- Creating a **class** with a **void method** that takes two integer parameters.  
- Performing a **mathematical operation** on the first integer.  
- Displaying the **second integer** to the console.  
- Calling the method using **both positional arguments and named parameters**.  

## **How It Works**  
1. The `MathClass` contains a method `PerformOperation(int num1, int num2)`, which:
   - Multiplies `num1` by 2.
   - Displays `num2` as-is.  
2. The `Main()` method:
   - Creates an instance of `MathClass`.  
   - Calls `PerformOperation()` with **positional arguments** (`5, 10`).  
   - Calls `PerformOperation()` with **named parameters** (`num1: 7, num2: 15`).  
3. The output is displayed in the console.  

## **Code Example**
```csharp
// Create an instance of MathClass
MathClass mathObj = new MathClass();

// Call method using positional arguments
mathObj.PerformOperation(5, 10);

// Call method using named parameters
mathObj.PerformOperation(num1: 7, num2: 15);
