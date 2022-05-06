using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioQR
{
    public interface IQrScanningService
    {
        Task<String> ScanAsync();
    }
}
