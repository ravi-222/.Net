﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int C2f(int c); // convert Celsius temperature to Fahrenheit temperature
                        
        [OperationContract]
        int F2c(int f); // convert Fahrenheit temperature to Celsius temperature

        [OperationContract]
        string Sort(string s); // sort a string of numbers, separated by commas
    }
}
