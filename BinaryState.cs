using System;

namespace Automaty_Komórkowe
{

    public class BinaryState : ICellState
    {
       
        public enum state
        {
            Dead = 0,
            Alive = 1
        }
        private int x;
        public BinaryState(int z)
        {
            x=z;
        }

        private state Dead = state.Dead;
        private state Alive = state.Alive;
        public Enum Unit{ get{ 
            if( x==0 )
                return Dead ; 
            
            else if( x == 1 )
                return Alive;
                
                else throw new Exception("Bad cell state in BinaryState file.");
    } 
    }
}
}

