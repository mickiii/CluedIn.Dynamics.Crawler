using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Factories;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public class StandardAppointmentClueProducer : AppointmentClueProducer<Appointment>
    {
        public StandardAppointmentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {

        }
    }
}

