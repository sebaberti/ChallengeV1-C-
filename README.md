<h1>Market + Auction Value CHALLENGE</h1>

# Project Description

This project is part of a challenge where equipment values are calculated using C#.

## Description

In this challenge, a simulated data structure representing equipment information is provided, including sales details and market and auction ratios for various years. The goal is to implement a function that calculates the market and auction values of equipment for a given year.

## Solution Explanation

### 1. Deserialization of Data
   - The solution begins by deserializing the provided JSON data into C# objects. This process involves converting the JSON string into instances of predefined C# classes using Newtonsoft.Json's `DeserializeObject` method.

### 2. Modularity with Classes and Functions
   - To enhance code readability and maintainability, the solution is modularized into classes and functions. Each class represents a specific data structure, such as equipment information, sale details, and schedules, allowing for better organization and abstraction of the data.

### 3. Parameter Passing
   - The main functionality revolves around a function that calculates the market and auction values of a given equipment for a specified year. Parameters such as equipment ID and year are passed to this function.

### 4. Dependency on External Library
   - It's important to note that the solution relies on the Newtonsoft.Json NuGet package for JSON deserialization. Therefore, anyone intending to run the project needs to install this package using NuGet Package Manager or .NET CLI.

### 5. Automated Execution
   - The project is designed to run automatically without requiring user input. The specified parameters for the challenge are passed to the relevant function, and the results are displayed in the console.

## Instructions for Testing

To test the project:

1. Clone the repository to your local machine.
2. Ensure that Newtonsoft.Json package is installed. If not, install it using NuGet Package Manager or .NET CLI.
3. Build and run the project.
4. The calculated market and auction values for the specified equipment IDs and years will be displayed in the console.

## Conclusion

By leveraging deserialization techniques, modularity, and proper parameter passing, the solution effectively addresses the challenge requirements, providing a clear and structured approach to calculating equipment values.

