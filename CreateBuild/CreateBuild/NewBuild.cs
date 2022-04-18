using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBuild
{
   public class NewBuild
    {
        static int number = 1;
        private int _numberOfBuild;
        private int _heightOfBuild;
        private int _countOfBuildFloors;
        private int _countOfApartment;
        private int _countOfEntrance;
        public int Number() { return number++; }
        public int NumberOfBuild { get { return _numberOfBuild = Number(); }
            set { _numberOfBuild = value; } }

        public int HeightOfBuild { get { return _heightOfBuild; } set {
                _heightOfBuild = value;
            } }
        public int CountOfBuildFloors { get { return _countOfBuildFloors; } set { _countOfBuildFloors = value; } }

        public int CountOfApartment { get { return _countOfApartment; } set { _countOfApartment = value; } }

        public int CountOfEntrance { get { return _countOfEntrance; } set { _countOfEntrance = value; } }
        public void CountApartmentOfEntrance(out int countApartmentOfEntrance)
        {


            countApartmentOfEntrance = CountOfApartment / CountOfEntrance;

        }
        public void CountApartmentOfFloor(out int countApartmentOfFloor, int countApartmenOfEntrance)
        {


            countApartmentOfFloor = countApartmenOfEntrance / CountOfBuildFloors;

        }
       
        public void HeightOfFloors(out int heightOfFloors) {
          
            
            heightOfFloors = HeightOfBuild / CountOfBuildFloors;
        
        }
        

    }
}
