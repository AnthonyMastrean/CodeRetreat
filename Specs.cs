using Machine.Specifications;

namespace Conways
{
    [Subject("Game of Life")]
    public class When_a_live_cell_has_fewer_than_two_live_neighbors
    {
        It should_die_from_under_population;
    }

    [Subject("Game of Life")]
    public class When_a_live_cell_has_two_live_neighbors
    {
        It should_live_on;
    }

    [Subject("Game of Life")]
    public class When_a_live_cell_has_three_live_neighbors
    {
        It should_live_on;
    }

    [Subject("Game of Life")]
    public class When_a_live_cell_has_more_than_three_live_neighbors
    {
        It should_die_from_over_crowding;
    }
    
    [Subject("Game of Life")]
    public class When_a_dead_cell_has_exactly_three_live_neighbors
    {
        It should_live_from_reproduction;
    }
}