using System;

namespace Automaty_Komórkowe
{
    public class UniformStateFactory : ICellState
    {/*
        public BinaryState CellState { get {return CellState;} set {CellState = value;} }

        public  UniformStateFactory()
            {}

        public UniformStateFactory(BinaryState x)
        {  
            try{
                if(CellState != BinaryState.Alive | CellState!= BinaryState.Dead)
                            throw   new System.Exception("Valuse is not valid.");
                 CellState = x;
                 System.Console.WriteLine("Działa");
        }
            catch(System.Exception exception){
                System.Console.WriteLine(exception);
        }
        }
*/
        public Enum cState => throw new NotImplementedException();
    }
}