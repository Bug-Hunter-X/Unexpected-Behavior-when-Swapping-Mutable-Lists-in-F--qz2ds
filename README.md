# Unexpected Behavior when Swapping Mutable Lists in F# 

This repository demonstrates an unexpected behavior when swapping mutable lists in F#. While swapping mutable integers works as expected, swapping mutable lists leads to both lists referencing the same memory location.

## Bug Description
The issue is observed when attempting to swap two mutable lists using mutable variables. The swap function modifies both lists, resulting in the unintended outcome of both lists having the same values after the swap.

## How to Reproduce
1. Clone this repository.
2. Open the `bug.fs` file.
3. Run the code.
4. Observe that the printed output shows both lists with the same values after attempting to swap them.

## Solution
The solution involves creating copies of the lists during the swap operation. This ensures that both lists maintain their original values before the swap, avoiding any unintended modification of the lists. The corrected code is available in the `bugSolution.fs` file. 

## Technologies Used
* F#