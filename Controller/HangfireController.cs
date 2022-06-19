using Hangfire;
using Microsoft.AspNetCore.Mvc;
using MvcApp1.backgroundService;

namespace MvcApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangfireController : Controller
    {
        private readonly IHangFireService _service;
        private readonly IBackgroundJobClient _backgroundjobclient;
        private readonly IRecurringJobManager _recurringjobnmanager;

        public HangfireController(
            IHangFireService service,
            IBackgroundJobClient backgroundjobclient,
            IRecurringJobManager recurringjobnmanager
        )
        {
            _service = service;
            _recurringjobnmanager = recurringjobnmanager;
            _backgroundjobclient = backgroundjobclient;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> CreateJob()
        {
            _backgroundjobclient.Schedule(() => _service.DelayedJob(), TimeSpan.FromSeconds(60));
            return Ok();
        }
        [HttpPost("[action]")]
        public async Task<ActionResult> CreateRecurringJob(string jobId)
        {
            _recurringjobnmanager.AddOrUpdate(jobId, () => _service.Reccuringjob(), Cron.Daily());
            return Ok();
        }
    }
}
