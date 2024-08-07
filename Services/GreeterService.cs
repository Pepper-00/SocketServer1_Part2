using Grpc.Core;
using SocketServer2;
using SocketServerProto;

namespace SocketServer2.Services
{
    public class GreeterService : testService.testServiceBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
            _ = tcp_Server2.RunAsync();
        }

        public override Task<respond_msg> Talk(request_msg request_, ServerCallContext context)
        {
            var response = new respond_msg { MsgResp = $"Message: {request_.MsgReq}" };
            return Task.FromResult(response);
        }
    }
}
