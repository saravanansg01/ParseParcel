using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseParcel
{
    public interface IParseParcel
    {
        string GetPackageSolution(PackageDetails objPackage);

        PackageSolutionDetails GetPackageSolutionWithRates(PackageDetails objPackage);
    }
}
