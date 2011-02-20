Conway's Game of Life

    An infinite grid of cells. Cells are either live or dead. At every game "turn", evaluate the 
    next generation of live and dead cells

    Rules

        1. A live cell with fewer than 2 live neighbors dies, as if by under-population.
        2. A live cell with 2 or 3 live neighbors lives on.
        3. A live cell with more than 3 live neighbors dies, as if by over-crowding.
        4. A dead cell with exactly 3 live neighbors becomes a live cell, as if by reproduction.


TDD as if you meant it

    1. Write implementation inside test method
    2. Extract implementation into either 
           A. new methods within the test class or 
           B. inside existing implementation methods
    3. Create implementation classes only as a destination for existing implementation methods
    4. Refactor as necessary
    5. Repeat!


4 rules of simple design (Kent Beck)

    1. Tests pass
    2. No duplication (code > concepts > DRY)
    3. Reveals intent (good names)
    4. Small