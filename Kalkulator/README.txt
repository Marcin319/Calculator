Calculator - Documentation
Project Description

The Calculator project is a Windows Forms application written in C#. It allows users to perform basic mathematical operations such as addition, subtraction, multiplication, division, calculating square roots, and handling parentheses in expressions.
Features

    Mathematical operations:
        Addition (+), subtraction (-), multiplication (*), division (/).
        Calculating square roots (√).
    Parentheses support: Enables the creation of more complex expressions.
    Input validation:
        Accepts only digits, mathematical operators, and parentheses.
        Blocks invalid characters and spaces.
    Clear button ("C"): Clears the input field.
    Equals button ("="): Evaluates the entered expression.
    Keyboard support:
        Pressing Enter or = calculates the expression.
        Accepts only valid characters during typing.

Main Methods

    Counting()
    The main method for calculations. Retrieves the expression from the input field, processes it, and displays the result.

    EvaluateExpression(string expression)
    Evaluates and calculates the value of a mathematical expression using the DataTable class.

    HandleSquareRoots(string expression)
    Handles square root (√) calculations in the expression.

    CheckDots()
    Checks if adding a dot (.) to the expression is valid (e.g., for decimal numbers).

    textBox1_KeyPress(object sender, KeyPressEventArgs e)
    Validates input in the text field, blocking invalid characters.

Project Structure

    Main file: Kalkulator.cs
    Main class: Kalkulator (inherits from Form)
    Interface elements:
        TextBox: Input field for entering expressions.
        Numeric and functional buttons: Add digits or operators to the input field.
        Control buttons: C (clear), = (calculate).

Technologies Used

    Programming Language: C#
    Framework: Windows Forms
    Libraries:
        System.Data.DataTable for mathematical computations.

Usage Instructions

    Enter a mathematical expression in the text field or use the buttons on the interface.
    Click = or press the Enter key to calculate the result.
    To clear the input field, click C.

Example Expressions

    2+3*4
    (5-3)^2
    √25 + 10/2

Notes

    If there is a syntax error in the expression, an exception will be thrown with details about the issue.
    Support for more advanced mathematical functions may require further implementation.