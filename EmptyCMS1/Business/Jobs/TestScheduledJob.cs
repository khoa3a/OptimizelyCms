using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.Web;
using System.ComponentModel;

namespace EmptyCMS1.Business.Jobs 
{ 

    [ScheduledPlugIn(
        DisplayName = "Test Job",
        Description = "Test Job",
        GUID = "8e08d22d-1751-426e-8c61-eafef1427770",
        DefaultEnabled = true
    )]
    public class TestScheduledJob: ScheduledJobBase
    {
        private bool _shouldContinue = true;

        public override string Execute()
        {
            if (_shouldContinue)
            {
                DoJob();
            }

            return "Job completed.";
        }

        public override void Stop()
        {
            _shouldContinue = false;
        }

        private void DoJob()
        {
            //TODO: add implementation
        }
    }
}
