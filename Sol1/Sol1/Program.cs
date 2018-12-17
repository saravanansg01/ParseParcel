using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseParcel;

namespace Sol1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PackageDetails objPackage = new PackageDetails();

                string strResult = string.Empty;

                //Console.WriteLine("Please enter the dimensions");
                int totalDimensions = 4;
                int inputDimension = 0;
                while (totalDimensions > 0)
                {
                    if (totalDimensions == 4)
                    {
                        Console.WriteLine("Please enter the package Length (in mm)");
                        if (int.TryParse(Console.ReadLine(), out inputDimension))
                        {
                            if (inputDimension > 0 && inputDimension < int.MaxValue)
                            {
                                objPackage.packageLength = inputDimension;
                                totalDimensions--;
                            }
                            else
                                Console.WriteLine("Invalid Length");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Length");
                        }
                    }
                    else if (totalDimensions == 3)
                    {
                        Console.WriteLine("Please enter the package Breadth (in mm)");
                        if (int.TryParse(Console.ReadLine(), out inputDimension))
                        {
                            if (inputDimension > 0 && inputDimension < int.MaxValue)
                            {
                                objPackage.packageBreadth = inputDimension;
                                totalDimensions--;
                            }
                            else
                                Console.WriteLine("Invalid Breadth");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Breadth");
                        }
                    }
                    else if (totalDimensions == 2)
                    {
                        Console.WriteLine("Please enter the package Height (in mm)");
                        if (int.TryParse(Console.ReadLine(), out inputDimension))
                        {
                            if (inputDimension > 0 && inputDimension < int.MaxValue)
                            {
                                objPackage.packageHeight = inputDimension;
                                totalDimensions--;
                            }
                            else
                                Console.WriteLine("Invalid Height");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Height");
                        }
                    }
                    else if (totalDimensions == 1)
                    {
                        Console.WriteLine("Please enter the package Weight (in kg)");
                        if (int.TryParse(Console.ReadLine(), out inputDimension))
                        {
                            if (inputDimension > 0 && inputDimension < int.MaxValue)
                            {
                                objPackage.packageWeight = inputDimension;
                                totalDimensions--;
                            }
                            else
                                Console.WriteLine("Invalid Weight");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Weight");
                        }
                    }
                }

                //Using Interface to implement so that any changes in the future will break the actual implementation
                IParseParcel objParseParcel = new ParseParcel.ParseParcel();
                PackageSolutionDetails objResult = new PackageSolutionDetails();
                //strResult = objParseParcel.GetPackageSolution(objPackage);
                objResult = objParseParcel.GetPackageSolutionWithRates(objPackage);

                //Console.WriteLine(strResult);
                Console.WriteLine("Package Type: {0}", (objResult != null && !string.IsNullOrEmpty(objResult.packageType)) ? objResult.packageType : "Not Applicable");
                Console.WriteLine("Package Rate: {0}", (objResult != null && objResult.packageRate.HasValue ? objResult.packageRate.Value.ToString() : "Not Applicable"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error " + ex.Message);
                //Log file can be configured to get the exception details
            }
            Console.ReadLine();
        }
    }
}
