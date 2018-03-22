using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codeproject.com/Articles/1135745/Dependency-Inversion-Principle-DIP
namespace SOLID_Principles
{
    //High-level modules should not depend upon low-level modules. Both should depend upon abstractions.
    //Abstractions should not depend upon details. Details should depend upon abstractions.

    #region DoesNotComply_DependencyInversionPrinciple
    public class HighLevelModule
    {
        private readonly LowLevelModule _lowLevelModule;

        public  HighLevelModule()
        {
            this._lowLevelModule = new LowLevelModule();
            //HighLevelModule depends directly on LowLevelModule and this does not follow the first point of DIP.

            //The direct and tightly coupled relationship between the two makes it harder to create unit tests on
            //HighLevelModule in isolation from LowLevelModule.

            //You are forced to test HighLevelModule and LowLevelModule at the same time because they are tightly coupled.
        }

        public void Call()
        {
            this._lowLevelModule.Initiate();
            this._lowLevelModule.Send();
        }
    }

    public class LowLevelModule
    {
        public void Initiate()
        {
            //do initiation before sending
        }

        public void Send()
        {
            //perform sending operation
        }
    }
    #endregion DoesNotComply_DependencyInversionPrinciple
    
}

namespace SOLID
{
    #region DependencyInversion_Applied
    //The first point of DIP suggest us to apply two things at the same time to the codes:
    //Abstraction,
    //Dependency Inversion or Inversion of Control

    //Firstly, LowLevelModule need to be abstracted and HighLevelModule will depend on the abstraction instead. 
    // here will use an interface for the abstraction. An IOperation interface is used to abstract LowLevelModule.
    public interface IOperation
    {
        void Initiate();
        void Send();
    }

    public class LowLevelModule : IOperation
    {
        public void Initiate()
        {
            //do initiation before sending
        }

        public void Send()
        {
            //perform sending operation
        }
    }

    public class HighLevelModule
    {
        private readonly IOperation _operation;

        //The implementation of the abstraction,LowLevelModule, or behavior need to be passed from 
        //outside of HighLevelModule, and the process of moving this from inside to outside of the class is called inversion.

        //We have decoupled the HighLevelModule and LowLevelModule from each other, and both now depend 
        //on the abstraction IOperation.
        public HighLevelModule(IOperation operation)
        {
            _operation = operation;
        }

        public void Call()
        {
            _operation.Initiate();
            _operation.Send();
        }
    }
    #endregion DependencyInversion_Applied
}