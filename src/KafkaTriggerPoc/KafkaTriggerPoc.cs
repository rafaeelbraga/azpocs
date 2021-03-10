using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Kafka;
using Microsoft.Extensions.Logging;

namespace KafkaTriggerPoc
{
    public static class KafkaTriggerPoc
    {
        [FunctionName("KafkaTriggerPoc")]
        public static void Run([KafkaTrigger("BrokerKafka", "kafka-topic", ConsumerGroup = "kafka-poc-consumer")] KafkaEventData<string> kafkaEvent, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {kafkaEvent.Value}");
        }
    }
}
