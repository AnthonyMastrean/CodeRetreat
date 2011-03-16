Conway's Game of Life
=====================
*As practiced at Code Retreats worldwide!*

[Rules](http://en.wikipedia.org/wiki/Conway's_Game_of_Life)
-----
An infinite grid of cells. Cells are either live or dead. At every game "turn", evaluate the next generation of live and dead cells
 1. A live cell with fewer than 2 live neighbors dies, as if by under-population.
 2. A live cell with 2 or 3 live neighbors lives on.
 3. A live cell with more than 3 live neighbors dies, as if by over-crowding.
 4. A dead cell with exactly 3 live neighbors becomes a live cell, as if by reproduction.

[TDD As If You Meant It](http://gojko.net/2009/02/27/thought-provoking-tdd-exercise-at-the-software-craftsmanship-conference/)
----------------------
  1. Write implementation inside test method
  2. Extract implementation into either 
    A. new methods within the test class or 
    B. inside existing implementation methods
  3. Create implementation classes only as a destination for existing implementation methods
  4. Refactor as necessary
  5. Repeat!

[Rules of Simple Design](http://c2.com/cgi/wiki?XpSimplicityRules)
------------------------------------
  1. Tests pass
  2. No duplication (code > concepts > DRY)
  3. Reveals intent (good names)
  4. Small