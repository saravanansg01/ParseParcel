using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseParcel
{
    public class PackageDetails
    {
        public int packageLength { get; set; }
        public int packageBreadth { get; set; }
        public int packageHeight { get; set; }
        public int packageWeight { get; set; }
    }
    public class PackageSolutionDetails
    {
        public string packageType { get; set; }
        public int? packageRate { get; set; }
    }
}
