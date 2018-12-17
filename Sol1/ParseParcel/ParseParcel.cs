using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseParcel
{
    public class ParseParcel : IParseParcel
    {
        public string GetPackageSolution(PackageDetails objPackage)
        {
            string strOutput = "Too big to handle";
            if (objPackage.packageWeight > ParcelConfig.maxPackageHeight)
                strOutput = "Too heavy to handle for us now...";
            else if (isTooLengthy(objPackage.packageLength))
                strOutput = "Too lengthy to handle for us now...";
            else if (isTooBreadthy(objPackage.packageBreadth))
                strOutput = "Too wider to handle for us now...";
            else if (isTooHeighter(objPackage.packageHeight))
                strOutput = "Too heighter to handle for us now...";
            else if (isSmallPackage(objPackage))
                strOutput = ParcelConfig.smallPackageType;
            else if (isMediumPackage(objPackage))
                strOutput = ParcelConfig.mediumPackageType;
            else if (isLargePackage(objPackage))
                strOutput = ParcelConfig.largePackageType;

            return strOutput;
        }

        public PackageSolutionDetails GetPackageSolutionWithRates(PackageDetails objPackage)
        {
            //string strOutput = "Too big to handle";
            PackageSolutionDetails objsolution = new PackageSolutionDetails();
            if (objPackage.packageWeight > ParcelConfig.maxPackageHeight)
            {
                objsolution.packageType = "Too heavy to handle for us now...";
                objsolution.packageRate = null;
            }
            else if (isTooLengthy(objPackage.packageLength))
            {
                objsolution.packageType = "Too lengthy to handle for us now...";
                objsolution.packageRate = null;
            }
            else if (isTooBreadthy(objPackage.packageBreadth))
            {
                objsolution.packageType = "Too wider to handle for us now...";
                objsolution.packageRate = null;
            }
            else if (isTooHeighter(objPackage.packageHeight))
            {
                objsolution.packageType = "Too heighter to handle for us now...";
                objsolution.packageRate = null;
            }
            else if (isSmallPackage(objPackage))
            {
                objsolution.packageType = ParcelConfig.smallPackageType;
                objsolution.packageRate = ParcelConfig.smallPackageRate;
            }
            else if (isMediumPackage(objPackage))
            {
                objsolution.packageType = ParcelConfig.mediumPackageType;
                objsolution.packageRate = ParcelConfig.mediumPackageRate;
            }
            else if (isLargePackage(objPackage))
            {
                objsolution.packageType = ParcelConfig.largePackageType;
                objsolution.packageRate = ParcelConfig.largePackageRate;
            }

            return objsolution;
        }

        private bool isSmallPackage(PackageDetails objPackage)
        {
            bool blnOutput = false;
            if (objPackage.packageLength <= ParcelConfig.smallPackageLength ||
                objPackage.packageBreadth <= ParcelConfig.smallPackageBreadth ||
                objPackage.packageHeight <= ParcelConfig.smallPackageHeight)
                blnOutput = true;

            return blnOutput;
        }

        private bool isMediumPackage(PackageDetails objPackage)
        {
            bool blnOutput = false;
            if (objPackage.packageLength <= ParcelConfig.mediumPackageLength ||
                objPackage.packageBreadth <= ParcelConfig.mediumPackageBreadth ||
                objPackage.packageHeight <= ParcelConfig.mediumPackageHeight)
                blnOutput = true;

            return blnOutput;

        }

        private bool isLargePackage(PackageDetails objPackage)
        {
            bool blnOutput = false;
            if (objPackage.packageLength <= ParcelConfig.largePackageLength ||
                objPackage.packageBreadth <= ParcelConfig.largePackageBreadth ||
                objPackage.packageHeight <= ParcelConfig.largePackageHeight)
                blnOutput = true;

            return blnOutput;

        }

        private bool isTooLengthy(int packageLength)
        {
            bool blnOutput = false;
            if (packageLength > ParcelConfig.largePackageLength)
                blnOutput = true;
            return blnOutput;
        }

        private bool isTooBreadthy(int packageBreadth)
        {
            bool blnOutput = false;
            if (packageBreadth > ParcelConfig.largePackageBreadth)
                blnOutput = true;
            return blnOutput;
        }

        private bool isTooHeighter(int packageHeight)
        {
            bool blnOutput = false;
            if (packageHeight > ParcelConfig.largePackageHeight)
                blnOutput = true;
            return blnOutput;
        }
        //private PackageSolutionDetails PackageSolution()
        //{

        //}
    }
}
