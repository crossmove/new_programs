using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFeatures
{
    public class InterfaceDriver
    {
        public static void driver()
        {
            UpcastingDowncasting obj = new UpcastingDowncasting();
            obj.PositiveCase();
            obj.NegativeCase();

            //We have created an obj for Lift_Custom so all the methods can be accessed
            Lift_Custom liftObj = new Lift_Custom();
            liftObj.Start();
            liftObj.Stop();
            liftObj.Call();

            //Here we create object of Lift_Custom the start and stop methods are available 
            //but Call method wont available as its not available in interface Lift, 
            //the same is applicable for base class and derived class scenarios.
            Lift liftInterfaceObj = new Lift_Custom();
            liftInterfaceObj.Start();
            liftInterfaceObj.Stop();
        }
    }
    public interface Lift
    {
      //Interafe members should not contain access modifiers, if you add any access modifiers to the members it will throw following error msg
      //The modifier 'public' is not valid for this item
        void Start();
        void Stop();
    }
    public class Lift_Custom : Lift
    {
        public void Start()
        {
            Console.WriteLine("Enter");
        }

        public void Stop()
        {
            Console.WriteLine("Exit");
        }

        public void Call()
        {
            Console.WriteLine("Call Operator");
        }
    }
}
