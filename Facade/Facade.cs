using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class Facade
    {
        private ClassOne _one;
        private ClassTwo _two;
        private ClassThree _three;

        public Facade()
        {
            _one = new ClassOne();
            _two = new ClassTwo();
            _three = new ClassThree();
        }

        //Simplifing the calling for the operations of each class, 
        //supposing it is a convenient context for doing this
        public void CallOperationsUnified()
        {
            _one.OperationFromOne();
            _two.OperationFromTwo();
            _three.OperationFromThree();
        }
    }
}
