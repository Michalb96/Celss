namespace Automaty_Komórkowe
{
    public class Cords1D : ICellCoordinates
    {
        int x; 
        public int xCords{ get{return this.x;} set{}}
        public Cords1D()
        {
            x = -1;
        }
        public Cords1D( int z )
        {
            z = x;
        }
    }
}