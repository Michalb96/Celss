using System;
using System.Collections.Generic;

namespace Automaty_Komórkowe
{
    public class Neighbourhood2D : ICellNeighbourhood, IWrapping
    {

        private int height, width ; 
        private int wrap;
        public int distance; 

        public Neighbourhood2D()
        {
            wrap=0;
            height= 0;
            width = 0;
            distance = 0 ;

        }

        public Enum IOnOff { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public HashSet<ICellCoordinates> cellNeighbours(ICellCoordinates cell)
        {
            throw new NotImplementedException();
        }
    }
}