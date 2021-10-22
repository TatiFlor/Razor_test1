using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Razor_test1.Models;
using Razor_test1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_test1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileRowService RowService; //private

        public JsonFileStatusService StatusService;

        public JsonFileAnalyzerService AnalyzerService;

        public JsonFileDetectorService DetectorService;

        public JsonFileParameterService ParameterService;

        public JsonFilePlcService PlcService;

        public JsonFileLicenseService LicenseService;
        public IEnumerable<Row> Rows { get; private set; }

        public IEnumerable<Status> Statuses { get; private set; }

        public IEnumerable<Analyzer> Analyzers { get; private set; }

        public IEnumerable<Detector> Detectors { get; private set; }
        public IEnumerable<Plc> Plcs { get; private set; }

        public IEnumerable<Param> Params { get; private set; }

        public IEnumerable<License> Licenses { get; private set; }
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileStatusService statusService,
            JsonFileRowService rowService,
            JsonFileAnalyzerService analyzerService,
            JsonFileDetectorService detectorService,
            JsonFilePlcService plcService,
            JsonFileParameterService paramService,
            JsonFileLicenseService licenseService)
        {
            RowService = rowService;
            StatusService = statusService;
            AnalyzerService = analyzerService;
            DetectorService = detectorService;
            PlcService = plcService;
            ParameterService = paramService;
            LicenseService = licenseService;
            _logger = logger;
        }

        public void OnGet()
        {
            Rows = RowService.GetRows();
            Statuses = StatusService.GetStatuses();
            Analyzers = AnalyzerService.GetAnalyzers();
            Detectors = DetectorService.GetDetectors();
            Plcs = PlcService.GetPlcs();
            Params = ParameterService.GetParams();
            Licenses = LicenseService.GetLicenses();
        }
    }
}
