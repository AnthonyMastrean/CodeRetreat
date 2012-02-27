# Conway's Game of Life
*As practiced at Code Retreats worldwide!*

## [Rules](http://en.wikipedia.org/wiki/Conway's_Game_of_Life)
An infinite grid of cells. Cells are either live or dead. At every game "turn", evaluate the next generation of live and dead cells

1. A live cell with fewer than 2 live neighbors dies, as if by under-population.
2. A live cell with 2 or 3 live neighbors lives on.
3. A live cell with more than 3 live neighbors dies, as if by over-crowding.
4. A dead cell with exactly 3 live neighbors becomes a live cell, as if by reproduction.

## [TDD As If You Meant It](http://gojko.net/2009/02/27/thought-provoking-tdd-exercise-at-the-software-craftsmanship-conference/)
1. Write implementation inside test method
2. Extract implementation into either 
  A. new methods within the test class or 
  B. inside existing implementation methods
3. Create implementation classes only as a destination for existing implementation methods
4. Refactor as necessary
5. Repeat!

## [Rules of Simple Design](http://c2.com/cgi/wiki?XpSimplicityRules)
1. Tests pass
2. No duplication (code > concepts > DRY)
3. Reveals intent (good names)
4. Small

## [Perfecting Small Classes and Short Methodshttp://binstock.blogspot.com/2008/04/perfecting-oos-small-classes-and-short.html
1. Use only one level of indentation per method.
2. Don’t use the ‘else’ keyword.
3. Wrap all primitives and strings.
4. Use only one dot per line.
5. Don’t abbreviate names.
6. Keep entities small.
7. Don’t use any classes with more than two instance variables.
8. Use first-class collections.
9. Don’t use setters, getters, or properties.

## Reference
* [Game of Life](http://blog.objectmentor.com/articles/2010/08/15/game-of-life-with-lunivore) with Bob Martin and lunivore
* Game of Life [in Erlang](https://gist.github.com/1225511) in 20 lines!
* Game of Life [in APL](http://www.youtube.com/watch?v=a9xAKttWgP4) (in 8 minutes!)