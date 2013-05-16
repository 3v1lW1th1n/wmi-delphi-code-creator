//-----------------------------------------------------------------------------------------------------
//     This code was generated by the Wmi Delphi Code Creator (WDCC) Version [VERSIONAPP]
//     http://code.google.com/p/wmi-delphi-code-creator/
//     Blog http://theroadtodelphi.wordpress.com/wmi-delphi-code-creator/
//     Author Rodrigo Ruz V. (RRUZ) Copyright (C) 2011-2013 
//----------------------------------------------------------------------------------------------------- 
//
//     LIABILITY DISCLAIMER
//     THIS GENERATED CODE IS DISTRIBUTED "AS IS". NO WARRANTY OF ANY KIND IS EXPRESSED OR IMPLIED.
//     YOU USE IT AT YOUR OWN RISK. THE AUTHOR NOT WILL BE LIABLE FOR DATA LOSS,
//     DAMAGES AND LOSS OF PROFITS OR ANY OTHER KIND OF LOSS WHILE USING OR MISUSING THIS CODE.
//
//----------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace GetWMI_Info
{
    class Program
    {
[WMICLASSDESC]		
        static void Main(string[] args)
        {
            try
            {
                string ComputerName = "localhost";
                ManagementScope Scope;                

                if (!ComputerName.Equals("localhost", StringComparison.OrdinalIgnoreCase)) 
                {
                    ConnectionOptions Conn = new ConnectionOptions();
                    Conn.Username  = "";
                    Conn.Password  = "";
                    Conn.Authority = "ntlmdomain:DOMAIN";
                    Scope = new ManagementScope(String.Format("\\\\{0}\\[WMINAMESPACE]", ComputerName), Conn);
                }
                else
                    Scope = new ManagementScope(String.Format("\\\\{0}\\[WMINAMESPACE]", ComputerName), null);

                Scope.Connect();
                ObjectQuery Query = new ObjectQuery("SELECT * FROM [WMICLASSNAME]");
                ManagementObjectSearcher Searcher = new ManagementObjectSearcher(Scope, Query);

                foreach (ManagementObject WmiObject in Searcher.Get())
                {
[CSHARPCODE]	                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("Exception {0} Trace {1}",e.Message,e.StackTrace));
            }
            Console.WriteLine("Press Enter to exit");
            Console.Read();
        }
    }
}


