using System;
using System.Reflection;
using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AppServiceScaleOut.Pages
{
    public class IndexModel : PageModel
    {
        public string MachineName { get; set; }
        public string OS { get; set; }
        public int ProcessorCount { get; set ;}
        public string Framework { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            MachineName = Environment.MachineName;
            OS = Environment.OSVersion.VersionString;
            ProcessorCount = Environment.ProcessorCount;
            Framework = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
        }
    }
}
