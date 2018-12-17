using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseParcel
{
    class ParcelConfig
    {
        //Small Package Solution Dimensions Config
        public static int smallPackageLength = 200;
        public static int mediumPackageLength = 300;
        public static int largePackageLength = 400;

        //Small Package Solution Config for Type and Rate
        public static string smallPackageType = "Small";
        public static int smallPackageRate = 50;

        //Medium Package Solution Dimensions Config
        public static int smallPackageBreadth = 200;
        public static int mediumPackageBreadth = 300;
        public static int largePackageBreadth = 400;

        //Medium Package Solution Config for Type and Rate
        public static string mediumPackageType = "Medium";
        public static int mediumPackageRate = 75;

        //Large Package Solution Dimensions Config
        public static int smallPackageHeight = 200;
        public static int mediumPackageHeight = 300;
        public static int largePackageHeight = 400;

        //Large Package Solution Config for Type and Rate
        public static string largePackageType = "Large";
        public static int largePackageRate = 100;

        //Maximum Weight Config
        public static int maxPackageHeight = 25;

    }
}
