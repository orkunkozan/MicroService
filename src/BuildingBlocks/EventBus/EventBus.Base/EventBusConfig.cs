using EventBus.Base.Types;

namespace EventBus.Base
{
    public class EventBusConfig
    {
        public int ConnectionRetryCount { get; set; } = 5;

        public string DefaultTopicName { get; set; } = "MicroServicesEventBus";

        public string EventBusConnectionString { get; set; } = string.Empty;

        public string SubscribrClientAppName { get; set; } = string.Empty;

        public string EventNamePrefix { get; set; } = string.Empty;

        public string EventNameSuffix { get; set; } = "IntegrationEvent";

        public EventBusType EventBusType { get; set; } = EventBusType.RabbitMQ;

        public object Connection { get; set; }

        public bool DeleteEventPrefix => !String.IsNullOrEmpty(EventNamePrefix);

        public bool DeleteEventSuffix => !String.IsNullOrEmpty(EventNameSuffix);
    }
}
