namespace Automaty_Komórkowe
{
    public interface ICellNeighbourhood
    {
        System.Collections.Generic.HashSet <ICellCoordinates>  cellNeighbours(ICellCoordinates cell);

    }
}