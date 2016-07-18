using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Base
{
    public abstract class Construct
    {
        public abstract void Execute();

        public abstract Construct Create();

        public abstract void Cast();

        protected virtual Learn(Context context, Request request)
        {

        }

        protected bool IsOK()
        {

        }

        protected override Transport Change(Request request)
        {
            Transport transport = Transport.Create(request, new Response());

            Progress.Start(transport);
            transport.AssumingValidity().Learn().GetFeedback(_feedbackFeed).LearnAgain().ScheduleChange().PublishEvents().UpdateStates();
            Progress.End(transport);

            return transport;
        }

        protected override protected Process()
        {
            _feedback.Request(request, response).IsNotAccepted(request, response).ThenRevert(request, response).AndLearnAgain(request, response);
        }

        protected override Learn(Context context, Request request)
        {
            Remember(request);

            Patterns patterns = Patterns.Retrieve(context, request, this.Construct);
            Pattern pattern = patterns.Strongest();

            LearningResponse response = LearningResponse.Suggest(request, pattern);

            Remember(response);

            return response;
        }

        bool protected IsOK(Request request, Response response)
        {
            return IsSecure(request, response).HasPermision(request, response).AndValidates(request, response);
        }

    }
}
