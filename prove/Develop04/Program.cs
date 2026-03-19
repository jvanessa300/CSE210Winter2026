using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity baseActivity= new BaseActivity("Breathing",
        "This activity will help you breath better.");

        baseActivity.DisplayGreeting();
        baseActivity.DisplayDescription();
        
        baseActivity.DisplaySpinner("Hey Bob, 5");

    }

}