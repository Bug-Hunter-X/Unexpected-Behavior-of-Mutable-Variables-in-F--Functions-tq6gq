# Unexpected Behavior of Mutable Variables in F# Functions

This repository demonstrates an uncommon error related to the behavior of mutable variables in F# when passed as arguments to functions.  Specifically, the example highlights the difference between swapping mutable variables within the same scope versus swapping them within a function's scope.

## Bug Description

In F#, mutable variables are passed by value, meaning the function receives a copy of the variable's value, not a reference to the original variable.  Therefore, modifications made to the variable within the function do not affect the original variable outside the function's scope. This is different from some other languages that allow pass-by-reference for mutable variables.

## Solution

The solution involves understanding this behavior and avoiding modifying mutable variables that are passed into functions in the manner shown.  There are ways to achieve what you want, either by returning the values or by using mutable variables outside of the function's scope and working with references.
