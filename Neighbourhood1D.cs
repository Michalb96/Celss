using System;
using System.Collections.Generic;

namespace Automaty_Komórkowe
{
    public class Neighbourhood1D : ICellNeighbourhood , IWrapping
    {
        
        
        private int BoardLength;
        private int wrap;
        public enum OnOff{
            Off = 0,
            On = 1
        }
        public Enum IOnOff { get{
            if(wrap == 0)
            return OnOff.Off;
            else if(wrap == 1)
            return OnOff.On;
            else 
            throw new Exception("Value of wrapping is different of Off and On");
        } 
         set => throw new NotImplementedException();
          }
       //default constructor
        public Neighbourhood1D()
        {
            BoardLength = 1;
            wrap = 0;
        }
        //constructor
        public Neighbourhood1D(int board, int wra)
        {
            if( board < 1 )
            throw new Exception("BoardLength cant be less than 1 (Neighbourhood1D const with parameters.).");
            
            this.BoardLength = board;
            this.wrap = wra;
        }
        // checking if Cell is in Board
        public bool isOutside( int x )
        {
            if (x < 0 || x >= BoardLength)
                return true;
                
                else return false ;
        }

        public HashSet<ICellCoordinates> cellNeighbours(ICellCoordinates cell)
        {
            Cords1D current = (Cords1D) cell;
            int left1 =  current.xCords - 1;
            int right1 =  current.xCords + 1;
            HashSet<ICellCoordinates> NewCellNeighbours = new HashSet<ICellCoordinates>();
            Cords1D LeftCords = new Cords1D();
            LeftCords = GetCoordinates(left1);
            Cords1D RightCords = new Cords1D();
            RightCords = GetCoordinates(right1);
            if(LeftCords.xCords != -1)
            {
                NewCellNeighbours.Add(LeftCords);
            }
            if(RightCords.xCords != -1)
            {
                NewCellNeighbours.Add(RightCords);
            }

            //NewCellNeighbours.Add(left);
            return NewCellNeighbours;
        }
        public Cords1D GetCoordinates ( int x )
        {
                if ( isOutside(x) )
                    {
                        if ( wrap == 1 )
                        {
                            Console.WriteLine("jestem w wrap 1 ");
                            return new Cords1D ( mirrorX(x) ) ;
                            
                        }
                        else Console.WriteLine("jestem w wrap 1 ");
                        return new Cords1D();
                        
                    }
                else Console.WriteLine("jestem w dupie ");
                return new Cords1D(x);
                
        }
        // method used to rebuild cell position
        public int mirrorX ( int x ) 
        {
                if( !isOutside(x) )
                    throw new Exception (" You want to invert normal cell. ( Neighbourhood1D).");
                else 
                return BoardLength - Math.Abs(x);    
        }

    }
}